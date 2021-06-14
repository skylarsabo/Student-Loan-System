//using Microsoft.AspNetCore.Hosting;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoanTest
{
    class StudentLoan
    {
        int loanPrinciple = 0;
        int loanInterestRate = 0; // In percentage
        int loanPaymentPeriodStartDate = 0; //Format should be yyyymmdd
        int loanPaymentPeriodLength = 0; //Number of months

        public StudentLoan(int newLoanPrinciple, int newLoanInterestRate, int newLoanPaymentPeriodStartDate, int newLoanPaymentPeriodLength)
        {
            loanPrinciple = newLoanPrinciple;
            loanInterestRate = newLoanInterestRate;
            loanPaymentPeriodStartDate = newLoanPaymentPeriodStartDate;
            loanPaymentPeriodLength = newLoanPaymentPeriodLength;
        }

        public StudentLoan()
        {
            loanPrinciple = 0;
            loanInterestRate = 0;
            loanPaymentPeriodStartDate = 0;
            loanPaymentPeriodLength = 0;
        }

        public int getLoanPrinciple() { return loanPrinciple; }

        public int getLoanInterestRate() { return loanInterestRate; }

        public int getLoanPaymentPeriodStartDate() { return loanPaymentPeriodStartDate; }

        public int getLoanPaymentPeriodLength() { return loanPaymentPeriodLength; }

        public void setLoanPrinciple(int newLoanPrinciple) { loanPrinciple = newLoanPrinciple; }

        public void setLoanInterestRate(int newLoanInterestRate) { loanInterestRate = newLoanInterestRate; }

        public void setLoanPaymentPeriodStartDate(int newLoanPaymentPeriodStartDate) { loanPaymentPeriodStartDate = newLoanPaymentPeriodStartDate; }

        public void setLoanPaymentPeriodLength(int newLoanPaymentPeriodLength) { loanPaymentPeriodLength = newLoanPaymentPeriodLength; }



    }

}