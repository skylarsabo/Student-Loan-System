using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoanSystem.Data.Users
{
    public class Student
    {
        //ID is usertype
        public int Id { get; set; }
        public string Username { get; set; }



        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentID { get; set; }
        public int creditScore { get; set; }
        public string email { get; set; }

        public Loan loanApplyingFor { get; set; }
        public List<Loan> ApplyForLoansList { get; set; }
        public int SelectApplyForLoanValue { get; set; }
        public List<Loan> studentLoans { get; set; }

        public List<Loan> currentStudentLoans { get; set; }
    }
}
