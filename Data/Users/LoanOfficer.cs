using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoanSystem.Data.Users
{
    public class LoanOfficer : BaseUser
    {
        //Id is usertype
       //Display(Name="Username")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BankId { get; set; }


    }
}
