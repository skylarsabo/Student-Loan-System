using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StudentLoanSystem.Data;
using System;
using System.Linq;

namespace StudentLoanSystem.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new StudentLoanSystemContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<StudentLoanSystemContext>>()))
            {
                // Look for any movies.
                if (context.Student.Any())
                {
                    return;   // DB has been seeded
                }

                context.Student.AddRange(
                    new Student
                    {
                        ID = 1,
                        Name = "John Doe",
                        Phone = "9999999",
                        Email = "doe@mail.com"
                    },

                    new Student
                    {
                        Name = "John Doe",
                        Phone = "9999999",
                        Email = "doe@mail.com"
                    },

                    new Student
                    {
                        Name = "John Doe",
                        Phone = "9999999",
                        Email = "doe@mail.com"
                    },

                    new Student
                    {
                        Name = "John Doe",
                        Phone = "9999999",
                        Email = "doe@mail.com"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}