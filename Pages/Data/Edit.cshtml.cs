using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentLoanSystem.Models;
using StudentLoanSystem.Data.Users;

namespace StudentLoanSystem.Pages.Data
{
    public class EditModel : PageModel
    {
        private readonly StudentLoanSystem.Data.AccountData _context;

        public EditModel(StudentLoanSystem.Data.AccountData context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(database).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!databaseExists(database.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool databaseExists(int id)
        {
            return _context.Students.Any(e => e.Id == id);
        }
    }
}
