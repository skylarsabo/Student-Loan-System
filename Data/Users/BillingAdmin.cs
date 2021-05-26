using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoanSystem.Data.Users
{
    public class BillingAdmin : BaseUser
    {
        //Id is usertype
        [Display(Name="Username")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AdministrationId { get; set; }


    }
}
