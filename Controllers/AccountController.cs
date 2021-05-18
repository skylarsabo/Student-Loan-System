using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoanSystem.Controllers
{
    public class AccountController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }




        [Route("Login")]
        public async Task<IActionResult> OnPostLoginAsync()
        {
            System.Diagnostics.Debug.WriteLine("Login Sent To Data");

            return View("../Pages/Other/TestRedirectView");
        }




    }
}
