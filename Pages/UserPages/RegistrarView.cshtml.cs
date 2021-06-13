using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StudentLoanSystem.Pages.Data
{
    public class RegistrarViewModel : PageModel
    {
        private readonly StudentLoanSystem.Data.AccountData _context;
        public List<StudentLoanSystem.Data.Loan> LoanDatabase { get; set; }
        public List<StudentLoanSystem.Data.Users.Student> StudentDatabase { get; set; }
        public RegistrarViewModel(StudentLoanSystem.Data.AccountData context)
        {
            _context = context;
            StudentDatabase = StudentLoanSystem.Data.AccountData.RetrieveStudentList();
            LoanDatabase = StudentLoanSystem.Data.AccountData.RetrieveLoanList();
        }
        public void OnGet()
        {
        }
    }
}
