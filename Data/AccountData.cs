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

        public static string SQLDataSoure = "student-loan-server.database.windows.net";
        public static string SQLUserId = "student-loan-admin";
        public static string SQLPassword = "Password123";
        public static string SQLInitialCatalog = "student-loan-db";


        public static Student CurrentStudent { get; set; }

        //public AccountData() { }

        public AccountData(DbContextOptions<AccountData> options) : base(options) { }


         

        public DbSet<Student> Students { get; set; }
        public DbSet<Loan> Loans { get; set; }


        //public DbSet<AccountData> Id { get; set; }
        //public DbSet<AccountData> Username { get; set; }
        //public DbSet<AccountData> Password { get; set; }


        protected override void OnModelCreating(ModelBuilder mb)
        {
            // mb.Entity<AccountData>().ToTable("Id");
            // mb.Entity<AccountData>().ToTable("username");
            // mb.Entity<Student>().ToTable("Student");
        }

        //If check login good ---- grab user and create object to fill page from
        public static bool CheckLogin(String username, String password, int id)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = SQLDataSoure;
            builder.UserID = SQLUserId;
            builder.Password = SQLPassword;
            builder.InitialCatalog = SQLInitialCatalog;

            //System.Diagnostics.Debug.WriteLine(username + " " + id + " " + password);

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String sql = "SELECT username, password FROM test";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            if (reader.GetString(0).Trim().Equals(username, StringComparison.OrdinalIgnoreCase))
                            {
                                //System.Diagnostics.Debug.WriteLine("Username: {0}", reader.GetString(0));
                                if(reader.GetString(1).Trim().Equals(password, StringComparison.Ordinal))
                                {
                                    System.Diagnostics.Debug.WriteLine("Password: {0}", reader.GetString(1));
                                    return true;
                                }
                            }

                            
                        }
                        return false;
                    }
                }
            }







        }

        public static void PullInformationFromDB(String username, int id)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = SQLDataSoure;
            builder.UserID = SQLUserId;
            builder.Password = SQLPassword;
            builder.InitialCatalog = SQLInitialCatalog;
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String sql = "SELECT username, password FROM test";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        { }
                    }
                }
            }
        }

        public static Student Createuser(String username, int id) 
        {
            Data.Users.Student student = new()
            {
                Username = username,
                Id = id
            };
            CurrentStudent = student;
            return student;
        
        }
    }
}
