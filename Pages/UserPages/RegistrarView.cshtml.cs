using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace StudentLoanSystem.Pages.Data
{
    public class RegistrarViewModel : PageModel
    {
        private readonly StudentLoanSystem.Data.AccountData _context;
        public List<StudentLoanSystem.Data.Loan> LoanDatabase { get; set; }
        public List<StudentLoanSystem.Data.Users.Student> StudentDatabase { get; set; }
        [BindProperty]
        public string StudentID { get; set; }
        [BindProperty]
        public string MessageText { get; set; }
  
        public RegistrarViewModel(StudentLoanSystem.Data.AccountData context)
        {
            _context = context;
            StudentDatabase = StudentLoanSystem.Data.AccountData.RetrieveStudentList();
            LoanDatabase = StudentLoanSystem.Data.AccountData.RetrieveLoanList();
        }
        public async Task<IActionResult> OnPostSendMessageAsync()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "student-loan-server.database.windows.net";
            builder.UserID = "student-loan-admin";
            builder.Password = "Password123";
            builder.InitialCatalog = "student-loan-db";

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                connection.Open();
                String sql = "INSERT INTO MessageTable (StudentID, MessageText) VALUES ('";
                sql += StudentID;
                sql += "', '";
                sql += MessageText;
                sql += "');";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
                
            return Page();
        }
        public void OnGet()
        {
        }
    }
}
