using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentLoanSystem.Data;

namespace StudentLoanSystem.Pages.Data
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
            AboutToApprove = new int[] {1, 2, 3};
        }

        public List<StudentLoanSystem.Data.Loan> LoanDatabase { get; set; }
        public List<StudentLoanSystem.Data.Users.Student> StudentDatabase { get; set; }
        public List<Loan> approved { get; set; }
        [BindProperty]
        public List<Loan> unapproved { get; set; }
        public int[] AboutToApprove { get; set; }

        public async Task OnGet()
        {
        }

        public void OnPost(List<Loan> unapproved)
        {
            //foreach (var loan in LoanDatabase) 
           // {
           //     loan.Approved = loan.IsApproved ? 1 : 0;
            //}
        }
    }
}