using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentLoanSystem.Models;
using StudentLoanSystem.Data;

namespace StudentLoanSystem.Pages.Data
{
    public class LoanOfficerMainViewModel : PageModel
    {
        private readonly StudentLoanSystem.Data.StudentLoanSystemContext _context;

        public LoanOfficerMainViewModel(StudentLoanSystemContext context)
        {
            _context = context;
        }

        public IList<Student> database { get; set; }

        public async Task OnGetAsync()
        {
            database = await _context.Student.ToListAsync();
        }
    }
}