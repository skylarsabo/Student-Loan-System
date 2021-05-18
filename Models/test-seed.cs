using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Data.SqlClient;
using StudentLoanSystem.Data;
using StudentLoanSystem.Data.Users;

namespace StudentLoanSystem.Models
{
    public static class test_seed
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            
            
            

            
        }


        public static void AddStudents(AccountData dataContext)
        {
            if (dataContext.Students.Any())
            {
                return;
            }
            
            /*r studentList = new Student[]
            {
                new Student{Id=3,Username="student1",Password="test123"},
                new Student{Id=4,Username="student2",Password="test123"},
                new Student{Id=5,Username="student3",Password="test123"},
            };
            */
           //dataContext.Students.AddRange(studentList);
           //dataContext.SaveChanges();
            
        }


    }
}
