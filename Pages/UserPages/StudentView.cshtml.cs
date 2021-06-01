using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StudentLoanSystem.Pages.UserPages
{
    public class StudentViewModel : PageModel
    {

        //public string loanName { get; set; }

        public void OnGet()
        {
           // List<StudentLoanSystem.Data.Loan> studentLoanList = Data.AccountData.CurrentStudent.studentLoans;
           // StudentLoanSystem.Data.Loan studentLoan = studentLoanList[0];
           // loanName = studentLoan.loanName;
        }
    }
}
