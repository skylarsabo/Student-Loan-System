using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentLoanSystem.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StudentLoanSystem.Pages
{
    public class LoanOfficerMainViewModel : PageModel
    {
        public IList<Student> Students { get; set; }

        public LoanOfficerMainViewModel(StudentLoanSystemContext context)
        {

        }

        public void OnGet()
        {
        }
    }
}
