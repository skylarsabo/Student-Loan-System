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
    public class IndexModel : PageModel
    {
        private readonly StudentLoanSystem.Data.StudentLoanSystemContext _context;

        public IndexModel(StudentLoanSystem.Data.StudentLoanSystemContext context)
        {
            _context = context;
        }

        public IList<database> database { get;set; }

        public async Task OnGetAsync()
        {
            database = await _context.database.ToListAsync();
        }
    }
}
