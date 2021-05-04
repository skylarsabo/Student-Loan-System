using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StudentLoanSystem.Models;
using Microsoft.Extensions.DependencyInjection;
using StudentLoanSystem.Data.Users;

namespace StudentLoanSystem.Data
{
    public class AccountData : DbContext
    {
        public AccountData (DbContextOptions<AccountData> options) : base(options)
        {      
        }

        public DbSet<Student> Students { get; set; }

        //public DbSet<AccountData> Id { get; set; }

        //public DbSet<AccountData> Username { get; set; }
        //public DbSet<AccountData> Password { get; set; }


        protected override void OnModelCreating(ModelBuilder mb)
        {
            // mb.Entity<AccountData>().ToTable("Id");
            // mb.Entity<AccountData>().ToTable("username");
            mb.Entity<Student>().ToTable("Student");
        }









    }
}
