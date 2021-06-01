using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoanSystem.Data
{
    public class Loan
    {


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



    }
}
