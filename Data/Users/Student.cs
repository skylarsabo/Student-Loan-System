using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoanSystem.Data.Users
{
    public class Student : BaseUser
    {
        //ID is usertype
        public int Id { get; set; }
        public string Username { get; set; }



        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentID { get; set; }
        public string Email { get; set; }

        public Loan loanApplyingFor { get; set; }
        public List<Loan> ApplyForLoansList { get; set; }
        public int SelectApplyForLoanValue { get; set; }
        public List<Loan> studentLoans { get; set; }
        public int CreditScore { get; set; }
        public int Balance { get; set; }

        public List<Loan> currentStudentLoans { get; set; }

        public List<String> currentMessages { get; set; }
    }
}
