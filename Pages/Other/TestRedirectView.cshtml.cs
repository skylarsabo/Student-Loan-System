using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StudentLoanSystem.Pages
{
    public class TestRedirectViewModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult Login(string username, string password)
        {

            if (ModelState.IsValid)
            {
                //using(DB_)
            }

            if (username != null && password != null && username.Equals("acc1") && password.Equals("123"))
            {
                HttpContext.Session.SetString("username", username);
                return Page();
                //return View("_Success");
            }
            else
            {
                return Page();
                //ViewBag.error = "Invalid Account";
                //return View("Index");
            }
        }



    }
}
