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
    public class AccountData 
    {

        public static string SQLDataSoure = "student-loan-server.database.windows.net";
        public static string SQLUserID = "student-loan-admin";
        public static string SQLPassword = "Password123";
        public static string SQLInitialCatalog = "student-loan-db";


        public static Student CurrentStudent { get; set; }
        //public static Bank currentBank { get; set; }
        //public static Registar CurrentRegistar { get; set; }

        //public AccountData() { }

        //If check login good ---- grab user and create object to fill page from
        public static bool CheckLogin(Data.Users.BaseUser baseUser)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = SQLDataSoure;
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
            builder.DataSource = SQLDataSoure;
            builder.UserID = SQLUserID;
            builder.Password = SQLPassword;
            builder.InitialCatalog = SQLInitialCatalog;
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String sql = "SELECT studentID, username, firstName, lastName, creditScore FROM StudentTable";

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
                                student.creditScore = reader.GetInt32(4);
                                student.Username = student.Username;
                                student.Id = student.Id;
                            }
                        }
                    }
                }
            }
            return student;
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
                    return null;
                case 3:
                    return null;
                default:
                    return null;
            }
  
        }
    }
}
