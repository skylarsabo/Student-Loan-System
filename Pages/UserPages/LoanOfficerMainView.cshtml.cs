using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentLoanSystem.Data.Users;

namespace StudentLoanSystem.Pages.Data
{
    public class LoanOfficerMainViewModel : PageModel
    {
        private readonly StudentLoanSystem.Data.AccountData _context;

        public LoanOfficerMainViewModel(StudentLoanSystem.Data.AccountData context)
        {
            _context = context;
        }

        public IList<StudentLoanSystem.Data.Loan> LoanDatabase { get; set; }
        public IList<StudentLoanSystem.Data.Users.Student> StudentDatabase { get; set; }

        public async Task OnGetAsync()
        {
            LoanDatabase = await _context.Loans.ToListAsync();
            StudentDatabase = await _context.Students.ToListAsync();
        }
    }
}