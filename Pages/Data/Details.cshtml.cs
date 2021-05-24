using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentLoanSystem.Models;
using StudentLoanSystem.Data.Users;

namespace StudentLoanSystem.Pages.Data
{
    public class DetailsModel : PageModel
    {
        private readonly StudentLoanSystem.Data.AccountData _context;

        public DetailsModel(StudentLoanSystem.Data.AccountData context)
        {
            _context = context;
        }

        public Student database { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            database = await _context.Students.FirstOrDefaultAsync(m => m.Id == id);

            if (database == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
