using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentLoanSystem.Models;

namespace StudentLoanSystem.Data
{
    public class StudentLoanSystemContext : DbContext
    {
        public StudentLoanSystemContext (DbContextOptions<StudentLoanSystemContext> options)
            : base(options)
        {
        }

        public DbSet<StudentLoanSystem.Models.Student> Student { get; set; }
    }
}
