using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using StudentLoanSystem.Pages.UserPages;

namespace StudentLoanSystem.Controllers
{
    public class LoanOfficerController : Controller
    {
        [HttpPost]
        public IActionResult Approve(LoanOfficerMainViewModel vm)
        {
            
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
