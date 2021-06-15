using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using StudentLoanSystem.Data;

namespace StudentLoanSystem.Pages.UserPages
{
    public class LoanOfficerMainViewModel : PageModel
    {
        private readonly AccountData _context;

        public LoanOfficerMainViewModel(AccountData context)
        {
            _context = context;
            StudentDatabase = AccountData.RetrieveStudentList();
            LoanDatabase = AccountData.RetrieveLoanList();
            approved = new List<Loan>(LoanDatabase.Where(loan => loan.Approved == 1));
            denied = new List<Loan>(LoanDatabase.Where(loan => loan.Approved == 2));
            unapproved = new List<Loan>(LoanDatabase.Where(loan => loan.Approved == 0));
            ApproveArray = new string[unapproved.Count];
            RiskResult = "";
        }

        public List<StudentLoanSystem.Data.Loan> LoanDatabase { get; set; }
        public List<StudentLoanSystem.Data.Users.Student> StudentDatabase { get; set; }
        public List<Loan> approved { get; set; }
        public List<Loan> denied { get; set; }
        public List<Loan> unapproved { get; set; }
        [BindProperty]
        public int CalcCreditScore { get; set; }
        [BindProperty]
        public int CalcYearlyIncome { get; set; }
        [BindProperty]
        public int CalcAmount { get; set; }
        [BindProperty]
        public int CalcAccountBalance { get; set; }
        [BindProperty]
        public string RiskResult { get; set; }
        [BindProperty]
        public string[] ApproveArray { get; set; }

        public async Task OnGet()
        {
        }

        public async Task<IActionResult> OnPostRiskCalculateAsync()
        {
            RiskResult = StudentLoanSystem.Data.RiskCalculator.calculateRisk(CalcCreditScore, CalcYearlyIncome, CalcAmount, CalcAccountBalance).ToString();
            return Page();
        }

        public async Task<IActionResult> OnPostSubmitLoansAsync()
        {

            for (var i = 0; i < ApproveArray.Length; i++)
            {
                if (ApproveArray.ElementAt(i) == "Approve")
                {
                    this.unapproved.ElementAt(i).Approved = 1;
                }
                else if (ApproveArray.ElementAt(i) == "Deny") 
                {
                    this.unapproved.ElementAt(i).Approved = 2;
                }
            }

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "student-loan-server.database.windows.net";
            builder.UserID = "student-loan-admin";
            builder.Password = "Password123";
            builder.InitialCatalog = "student-loan-db";

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                String sql = "UPDATE LoanTable SET approved='1' WHERE Id=";
                foreach (var item in this.unapproved.ToList())
                {
                    if (item.Approved == 1) {
                        sql += "'" + item.Id.ToString() + "' OR Id=";
                        this.unapproved.Remove(item);
                        this.approved.Add(item);
                    }
                }
                if (sql.EndsWith("' OR Id="))
                {
                    sql = sql.Substring(0, sql.Length - 7);

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

                sql = "UPDATE LoanTable SET approved='2' WHERE Id=";
                foreach (var item in this.unapproved.ToList())
                {
                    if (item.Approved == 2)
                    {
                        sql += "'" + item.Id.ToString() + "' OR Id=";
                        this.unapproved.Remove(item);
                        this.denied.Add(item);
                    }
                }
                if (sql.EndsWith("' OR Id="))
                {
                    sql = sql.Substring(0, sql.Length - 7);

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                connection.Close();
            }
            return Page();
        }
    }
}