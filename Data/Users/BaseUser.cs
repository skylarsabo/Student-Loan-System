using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoanSystem.Data.Users
{
    public class BaseUser
    {

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }
}
