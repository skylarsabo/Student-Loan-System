using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoanSystem.Data.Users
{
    public class LoanOfficer : BaseUser
    {

        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int LoanOfficerId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<Loan> LoansNeedingReview { get; set; }
        public List<Loan> AllLoans { get; set; }
        public List<Loan> ReviewedLoans { get; set; }
        public int BankId { get; set; }


    }
}
