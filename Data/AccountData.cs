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
        public static LoanOfficer CurrentLoanOfficer { get; set; }
        public static Registar CurrentRegistar { get; set; }
        public static List<Loan> LoanList { get; set; }
        public static List<Loan> NotAssignedLoans { get; set; }
        public static List<Loan> ApplyLoanList { get; set; }

        public static List<Loan> ReviewLoanList { get; set; }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> LoanListItems { get; set; }

        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> ApplyLoanListItems { get; set; }
        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> CurrentStudentLoanItems { get; set; }


        public static IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> ReviewLoanItems { get; set; }

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
                            //System.Diagnostics.Debug.WriteLine("Username: {0} Password: {1} usertype: {2}", reader.GetString(0), reader.GetString(1), reader.GetInt32(2));
                            if (reader.GetString(0).Trim().Equals(baseUser.Username, StringComparison.OrdinalIgnoreCase))
                            {
                                //System.Diagnostics.Debug.WriteLine("Username: {0}", reader.GetString(0));
                                if(reader.GetString(1).Trim().Equals(baseUser.Password, StringComparison.Ordinal))
                                {
                                    //System.Diagnostics.Debug.WriteLine("Password: {0}", reader.GetInt32(2));
                                    baseUser.Id = reader.GetInt32(2);
                                    connection.Close();
                                    return true;
                                }
                            }

                            
                        }
                        connection.Close();
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
                String sql = "SELECT studentID, username, firstName, lastName, creditScore, email FROM StudentTable";

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
                                student.email = reader.GetString(5);
                            }
                        }
                    }
                    connection.Close();
                }
            }
            UpdateStudentLoanLists(student);
            return student;
        }
        public static LoanOfficer RetriveLoanOfficerInformation(LoanOfficer loanOfficer)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = SQLDataSoure;
            builder.UserID = SQLUserID;
            builder.Password = SQLPassword;
            builder.InitialCatalog = SQLInitialCatalog;
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String sql = "SELECT bankId, username, firstName, lastName, email, phoneNumber FROM BankTable";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetString(1).Trim().Equals(loanOfficer.Username, StringComparison.OrdinalIgnoreCase))
                            {
                                loanOfficer.LoanOfficerId = reader.GetInt32(0);
                                loanOfficer.FirstName = reader.GetString(2);
                                loanOfficer.LastName = reader.GetString(3);
                                loanOfficer.Username = loanOfficer.Username;
                                loanOfficer.Id = loanOfficer.Id;
                                loanOfficer.email = reader.GetString(4);
                                loanOfficer.phoneNumber = reader.GetString(5);
                            }
                        }
                    }
                    connection.Close();
                }
            }
            UpdateLoanOfficerLoanLists(loanOfficer);
            return loanOfficer;
        }
        public static Registar RetriveRegistarInformation(Registar registar)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = SQLDataSoure;
            builder.UserID = SQLUserID;
            builder.Password = SQLPassword;
            builder.InitialCatalog = SQLInitialCatalog;
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String sql = "SELECT username, firstName, lastName FROM RegistarTable";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetString(0).Trim().Equals(registar.Username, StringComparison.OrdinalIgnoreCase))
                            {
                                registar.FirstName = reader.GetString(1);
                                registar.LastName = reader.GetString(2);
                                registar.Username = registar.Username;
                                registar.Id = registar.Id;
                            }
                        }
                    }
                    connection.Close();
                }
            }
            return registar;
        }

        public static void UpdateLoanOfficerLoanLists(LoanOfficer loanOfficer)
        {
            List<Loan> tempList = new List<Loan>();
            List<Loan> tempList1 = new List<Loan>();
            foreach (Loan loan in LoanList)
            {
                if (loan.assigned.Equals(1) && loan.approved.Equals(0))
                {
                    tempList.Add(loan);
                }
            }
            loanOfficer.LoansNeedingReview = tempList;
            IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> tempReviewLoanList = loanOfficer.LoansNeedingReview.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
            {
                Value = s.principle.ToString(),
                Text = s.loanName + " for " + s.principle.ToString()
            });
            ReviewLoanItems = tempReviewLoanList;
        }

        public static void UpdateStudentLoanLists(Student student)
        {           
            List<Loan> tempList = new List<Loan>();
            List<Loan> tempList2 = new List<Loan>();
            List<Loan> tempList3 = new List<Loan>();
            foreach (Loan loan in LoanList)
            {
                if (loan.studentId.Equals(student.StudentID))
                {
                    tempList.Add(loan);
                    if (loan.approved.Equals(0))
                    {
                        tempList2.Add(loan);
                    }
                    else
                    {
                        tempList3.Add(loan);
                    }
                }

            }
            student.studentLoans = tempList;
            student.ApplyForLoansList = tempList2;
            student.currentStudentLoans = tempList3;
            IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> tempCurrentStudentLoanItems = student.currentStudentLoans.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
            {
                Value = s.principle.ToString(),
                Text = s.loanName + " for " + s.principle.ToString()
            });
            IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> tempApplyLoanListItems = student.ApplyForLoansList.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
            {
                Value = s.principle.ToString(),
                Text = s.loanName + " for " + s.principle.ToString()
            });
            ApplyLoanListItems = tempApplyLoanListItems;
            CurrentStudentLoanItems = tempCurrentStudentLoanItems;
        }
        public static void RetriveLoans()
        {
            List<Loan> tempList = new List<Loan>();
            List<Loan> notAssignedTempList = new List<Loan>();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = SQLDataSoure;
            builder.UserID = SQLUserID;
            builder.Password = SQLPassword;
            builder.InitialCatalog = SQLInitialCatalog;
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String sql = "SELECT studentID, username, firstName, lastName, postTime, principle, rate, start, length, approved, name, assigned, creditScore FROM LoanTable";
                
                /*
                String rowAmtAssigned = "SELECT count(*) from LoanTable where columname = 'assigned'";

                using (SqlCommand command = new SqlCommand(rowAmtAssigned, connection))
                {
                    connection.Open();
                    count = (int)command.ExecuteScalar();                  
                }
                */

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int assignedCheck = reader.GetInt32(11);
                            if (assignedCheck.Equals( 1 ))
                            {
                                Loan newLoan = new Loan()
                                {
                                    studentId = reader.GetInt32(0),
                                    username = reader.GetString(1),
                                    firstName = reader.GetString(2),
                                    lastName = reader.GetString(3),
                                    postTime = reader.GetDateTime(4),
                                    principle = reader.GetInt32(5),
                                    rate = reader.GetInt32(6),
                                    start = reader.GetInt32(7),
                                    length = reader.GetInt32(8),
                                    approved = reader.GetInt32(9),
                                    loanName = reader.GetString(10),
                                    assigned = reader.GetInt32(11),
                                    creditScore = reader.GetInt32(12)
                                };
                                tempList.Add(newLoan);
                            } else
                            {
                                Loan newLoan = new Loan()
                                {
                                    principle = reader.GetInt32(5),
                                    rate = reader.GetInt32(6),
                                    length = reader.GetInt32(8),
                                    loanName = reader.GetString(10),
                                    assigned = reader.GetInt32(11)
                                };
                                tempList.Add(newLoan);
                                notAssignedTempList.Add(newLoan);
                            }
                            
                        }
                    }
                    connection.Close();
                }
            }
            LoanList = tempList;
            NotAssignedLoans = notAssignedTempList;
            IEnumerable<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> tempLoanListItems = NotAssignedLoans.Select(s => new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem
            {
                Value = s.principle.ToString(),
                Text = s.loanName + " for " + s.principle.ToString()
            });
            
            LoanListItems = tempLoanListItems;
            
        }       
        public static void ApplyForLoan(Student student)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = SQLDataSoure;
            builder.UserID = SQLUserID;
            builder.Password = SQLPassword;
            builder.InitialCatalog = SQLInitialCatalog;
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String sql = "UPDATE LoanTable SET studentId='" + student.StudentID + "',username='" + student.Username + "',firstName='" + student.FirstName + "',lastName='" + student.LastName + "',assigned='1',creditScore='" + student.creditScore + "' WHERE principle='" + student.loanApplyingFor.principle + "'";


                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            UpdateStudentLoanLists(student);
        }
        public static void AcceptLoan(Loan loan, LoanOfficer loanOfficer)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = SQLDataSoure;
            builder.UserID = SQLUserID;
            builder.Password = SQLPassword;
            builder.InitialCatalog = SQLInitialCatalog;
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String sql = "UPDATE LoanTable SET approved='1' WHERE studentId='" + loan.studentId + "' AND name='" + loan.loanName + "'";


                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            UpdateLoanOfficerLoanLists(loanOfficer);
        }
        public static void DenyLoan(Loan loan, LoanOfficer loanOfficer)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = SQLDataSoure;
            builder.UserID = SQLUserID;
            builder.Password = SQLPassword;
            builder.InitialCatalog = SQLInitialCatalog;
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String sql = "UPDATE LoanTable SET studentId=NULL, username=NULL, firstName=NULL, LastName=NULL, approved=0, assigned=0, creditScore=NULL WHERE studentId='" + loan.studentId + "' AND name='" + loan.loanName + "'";


                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            UpdateLoanOfficerLoanLists(loanOfficer);
        }
        public static Object CreateUser(String username, int id) 
        {
            RetriveLoans();
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
                    Data.Users.LoanOfficer loanOfficer = new()
                    {
                        Username = username,
                        Id = id
                    };
                    loanOfficer = RetriveLoanOfficerInformation(loanOfficer);
                    CurrentLoanOfficer = loanOfficer;
                    return loanOfficer;
                case 3:
                    Data.Users.Registar registar = new()
                    {
                        Username = username,
                        Id = id
                    };
                    registar = RetriveRegistarInformation(registar);
                    CurrentRegistar = registar;
                    return registar;
                default:
                    return null;
            }
  
        }



        public static void ResetDB()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = SQLDataSoure;
            builder.UserID = SQLUserID;
            builder.Password = SQLPassword;
            builder.InitialCatalog = SQLInitialCatalog;
            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                String sql = "UPDATE LoanTable SET studentId=NULL, username=NULL, firstName=NULL, LastName=NULL, approved=0, assigned=0, creditScore=NULL";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                String sql2 = "UPDATE LoanTable SET studentId='1111', username='student1', firstName='joe', LastName='jackson', approved='1', assigned='1', creditScore='750' WHERE Id = 1";
                String sql3 = "UPDATE LoanTable SET studentId='1111', username='student1', firstName='joe', LastName='jackson', approved='0', assigned='1', creditScore='750' WHERE Id = 2";
                String sql4 = "UPDATE LoanTable SET studentId='2222', username='student2', firstName='steve', LastName='smith', approved='1', assigned='1', creditScore='650' WHERE Id = 3";
                String sql5 = "UPDATE LoanTable SET studentId='2222', username='student2', firstName='steve', LastName='smith', approved='0', assigned='1', creditScore='650' WHERE Id = 4";
                using (SqlCommand command = new SqlCommand(sql2, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                using (SqlCommand command = new SqlCommand(sql3, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                using (SqlCommand command = new SqlCommand(sql4, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                using (SqlCommand command = new SqlCommand(sql5, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }



    }
}
