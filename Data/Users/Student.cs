using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoanSystem.Data.Users
{
    public class Student : BaseUser
    {
        //Id is usertype
        public int Id { get; set; }

        [Display(Name="Username")]
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentId { get; set; }


    }
}
