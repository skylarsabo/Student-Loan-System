using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StudentLoanSystem.Data.Users;

namespace StudentLoanSystem.Data
{
    public class AccountData : DbContext
    {

        public static string SQLDataSource = "student-loan-server.database.windows.net";
        public static string SQLUserID = "student-loan-admin";
        public static string SQLPassword = "Password123";
        public static string SQLInitialCatalog = "student-loan-db";


        public static Student CurrentStudent { get; set; }
        public static List<Student> Students { get; set; }
        public static LoanOfficer CurrentOfficer { get; set; }
        public static List<Loan> Loans { get; set; }
        //public static Registar CurrentRegistar { get; set; }

        // public AccountData(DbContextOptions<AccountData> options)
        //: base(options)
        //{ }

        //If check login good ---- grab user and create object to fill page from
        public static bool CheckLogin(Data.Users.BaseUser baseUser)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = SQLDataSource;
            builder.UserID = SQLUserID;
            builder.Password = SQLPassword;
            builder.InitialCatalog = SQLInitialCatalog;


            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String sql = "SELECT username, password, usertype FROM test";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            System.Diagnostics.Debug.WriteLine("Username: {0} Password: {1} usertype: {2}", reader.GetString(0), reader.GetString(1), reader.GetInt32(2));
                            if (reader.GetString(0).Trim().Equals(baseUser.Username, StringComparison.OrdinalIgnoreCase))
                            {
                                //System.Diagnostics.Debug.WriteLine("Username: {0}", reader.GetString(0));
                                if(reader.GetString(1).Trim().Equals(baseUser.Password, StringComparison.Ordinal))
                                {
                                    //System.Diagnostics.Debug.WriteLine("Password: {0}", reader.GetInt32(2));
                                    baseUser.Id = reader.GetInt32(2);
                                    return true;
                                }
                            }

                            
                        }
                        return false;
                    }
                }
            }







        }

        public static Student RetriveStudentInformation(Student student)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = SQLDataSource;
            builder.UserID = SQLUserID;
            builder.Password = SQLPassword;
            builder.InitialCatalog = SQLInitialCatalog;
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String sql = "SELECT studentID, username, firstName, lastName, CreditScore, email, phoneNumber FROM StudentTable";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        { 
                            if (reader.GetString(1).Trim().Equals(student.Username, StringComparison.OrdinalIgnoreCase))
                            {
                                student.StudentID = reader.GetInt32(0);
                                student.FirstName = reader.GetString(2);
                                student.LastName = reader.GetString(3);
                                student.CreditScore = reader.GetInt32(4);
                                student.Email = reader.GetString(5);
                                student.PhoneNumber = reader.GetString(6);
                                student.Username = student.Username;
                                student.Id = student.Id;
                            }
                        }
                    }
                }
            }
            return student;
        }

        public static LoanOfficer RetrieveOfficerInformation(LoanOfficer officer)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = SQLDataSource;
            builder.UserID = SQLUserID;
            builder.Password = SQLPassword;
            builder.InitialCatalog = SQLInitialCatalog;
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String sql = "SELECT * FROM BankTable";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetString(2).Trim().Equals(officer.Username, StringComparison.OrdinalIgnoreCase))
                            {
                                officer.BankId = reader.GetInt32(0);
                                officer.FirstName = reader.GetString(2);
                                officer.LastName = reader.GetString(3);
                                officer.Email = reader.GetString(5);
                                officer.PhoneNumber = reader.GetString(6);
                                officer.Username = officer.Username;
                                officer.Id = officer.Id;
                            }
                        }
                    }
                }
            }
            return officer;
        }




        public static List<Student> RetrieveStudentList()
        {
            Students = new List<Student>(); 
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = SQLDataSource;
            builder.UserID = SQLUserID;
            builder.Password = SQLPassword;
            builder.InitialCatalog = SQLInitialCatalog;
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String sql = "SELECT * FROM StudentTable";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Student student = new Student();

                            student.Id = reader.GetInt32(0);
                            student.StudentID = reader.GetInt32(1);
                            student.Username = reader.GetString(2);
                            student.FirstName = reader.GetString(3);
                            student.LastName = reader.GetString(4);
                            student.CreditScore = reader.GetInt32(5);
                            student.Email = reader.GetString(6);
                            student.PhoneNumber = reader.GetString(7);
                            Students.Add(student);
                        }
                    }
                }
            }
            return Students;
        }

        public static List<Loan> RetrieveLoanList()
        {
            Loans = new List<Loan>();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = SQLDataSource;
            builder.UserID = SQLUserID;
            builder.Password = SQLPassword;
            builder.InitialCatalog = SQLInitialCatalog;
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String sql = "SELECT * FROM LoanTable";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Loan loan = new Loan();
                            loan.Id = reader.GetInt32(0);
                            loan.StudentId = reader.GetInt32(1);
                            loan.Username = reader.GetString(2);
                            loan.FirstName = reader.GetString(3);
                            loan.LastName = reader.GetString(4);
                            loan.PostTime = reader.GetDateTime(5);
                            loan.Principle = reader.GetInt32(6);
                            loan.Rate = reader.GetInt32(7);
                            loan.Start = reader.GetInt32(8);
                            loan.Length = reader.GetInt32(9);
                            loan.Approved = reader.GetInt32(10);
                            Loans.Add(loan);
                        }
                    }
                }
            }
            return Loans;
        }


        public static Object CreateUser(String username, int id) 
        {
            switch (id)
            {
                case 1:
                    Data.Users.Student student = new()
                    {
                        Username = username,
                        Id = id
                    };
                    student = RetriveStudentInformation(student);
                    CurrentStudent = student;
                    return student;
                case 2:
                    Data.Users.LoanOfficer officer = new()
                    {
                        Username = username,
                        Id = id
                    };
                    officer = RetrieveOfficerInformation(officer);
                    CurrentOfficer = officer;
                    return officer;
                case 3:
                    return null;
                default:
                    return null;
            }
  
        }
    }
}
