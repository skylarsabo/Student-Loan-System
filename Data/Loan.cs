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

        //[Display(Name="Username")]
        public string Username { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentId { get; set; }
        public int Amount { get; set; }
        public DateTime PostTime { get; set; }


    }
}
