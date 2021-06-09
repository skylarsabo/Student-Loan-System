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
            unapproved = new List<Loan>(LoanDatabase.Where(loan => loan.Approved == 0));
            AboutToApprove = new bool[LoanDatabase.Count];
        }

        public List<StudentLoanSystem.Data.Loan> LoanDatabase { get; set; }
        public List<StudentLoanSystem.Data.Users.Student> StudentDatabase { get; set; }
        public List<Loan> approved { get; set; }
        public List<Loan> unapproved { get; set; }
        public bool[] AboutToApprove { get; set; }
        [BindProperty]
        public List<string> ApproveArray { get; set; }

        public async Task OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            for(var i = 0; i < ApproveArray.Count; i++) {
                if (ApproveArray.ElementAt(i) == "on") {
                    this.unapproved.ElementAt(i).Approved = 1;
                }
            }

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.ConnectionString = "Server=tcp:student-loan-server.database.windows.net,1433;Initial Catalog=student-loan-db;Persist Security Info=False;User Id=student-loan-admin;Password=Password123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            string SQLDataSource = "student-loan-server.database.windows.net";
            string SQLUserID = "student-loan-admin";
            string SQLPassword = "Password123";
            string SQLInitialCatalog = "student-loan-db";
            builder.DataSource = SQLDataSource;
            builder.UserID = SQLUserID;
            builder.Password = SQLPassword;
            builder.InitialCatalog = SQLInitialCatalog;

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String sql = "UPDATE LoanTable" +
                    " SET Approved=1" +
                    " WHERE Id=";
                foreach (var item in this.unapproved.ToList())
                {
                    if (item.Approved == 1) {
                        sql += " " + item.Id.ToString() + " OR Id=";
                        this.unapproved.Remove(item);
                        this.approved.Add(item);
                    }
                }
                
                sql = sql.Substring(0, sql.Length - 7);
                sql += ";";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                }
            }
            return Page();
        }
    }
}