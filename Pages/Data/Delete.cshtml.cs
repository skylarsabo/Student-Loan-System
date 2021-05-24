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
    public class DeleteModel : PageModel
    {
        private readonly StudentLoanSystem.Data.AccountData _context;

        public DeleteModel(StudentLoanSystem.Data.AccountData context)
        {
            _context = context;
        }

        [BindProperty]
        public Student database { get; set; }

        public async Task<IActionResult> OnGetAsync(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            database = await _context.Students.FirstOrDefaultAsync(m => m.Id == Id);

            if (database == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            database = await _context.Students.FindAsync(Id);

            if (database != null)
            {
                _context.Students.Remove(database);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
