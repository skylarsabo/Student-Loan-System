using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using StudentLoanSystem.Data;

namespace StudentLoanSystem.Pages.Data
{
    public class DeleteModel : PageModel
    {
        private readonly StudentLoanSystem.Data.StudentLoanSystemContext _context;

        public DeleteModel(StudentLoanSystem.Data.StudentLoanSystemContext context)
        {
            _context = context;
        }

        [BindProperty]
        public database database { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            database = await _context.database.FirstOrDefaultAsync(m => m.ID == id);

            if (database == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            database = await _context.database.FindAsync(id);

            if (database != null)
            {
                _context.database.Remove(database);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
