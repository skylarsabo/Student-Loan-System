using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using StudentLoanSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoanSystem.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly AccountData _accData;
        private readonly MvcOptions _mvcOp;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IndexModel(AccountData accData, IOptions<MvcOptions> mvcOp)
        {
            _accData = accData;
            _mvcOp = (MvcOptions)mvcOp;

        }

        public void OnGet()
        {

        }


        //public IActionResult Login()
        //{

            //return View("_Success");
        //}
        






        /*
        [Route("login")]
        [HttpPost]
        [ValidateAntiForgeryToken]
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
                //ViewBag.error = "Invalid Account";
                //return View("Index");
                return Page();
            }


        }
        */



    }

}
