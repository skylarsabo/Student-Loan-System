using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoanSystem.Data.Users
{
    public class LoanOfficer
    {

        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int LoanOfficerId { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public List<Loan> LoansNeedingReview { get; set; }
        public List<Loan> AllLoans { get; set; }
        public List<Loan> ReviewedLoans { get; set; }

    }
}
