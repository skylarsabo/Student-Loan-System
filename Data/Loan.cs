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
