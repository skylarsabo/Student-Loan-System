using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentLoanSystem.Models;
using StudentLoanSystem.Data;

namespace StudentLoanSystem.Pages.Data
{
    public class CreateModel : PageModel
    {
        private readonly StudentLoanSystem.Data.StudentLoanSystemContext _context;

        public CreateModel(StudentLoanSystem.Data.StudentLoanSystemContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Student database { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Student.Add(database);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
