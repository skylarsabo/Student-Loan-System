using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoanSystem.Data
{
    public class Loan
    {


        //Id is usertype
        public int Id { get; set; }
        public int studentId { get; set; }
        public string username { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime postTime { get; set; }
        public int principle { get; set; }
        public int rate { get; set; }
        public int start { get; set; }
        public int length { get; set; }
        public int approved { get; set; }
        public string loanName { get; set; }
        public int assigned { get; set; }
        public int creditScore { get; set; }


        public int StudentId { get; set; }
        //[Display(Name="Username")]
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime PostTime { get; set; }
        public int Principle { get; set; }
        public int Rate { get; set; }
        public int Start { get; set; }
        public int Length { get; set; }
        public int Approved { get; set; }
        public bool IsApproved { get; set; }
    }
}
