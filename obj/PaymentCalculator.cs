using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoanProgram
{
    class PaymentCalculator
    {
        var loanPrinciple = "";
        var loanInterestRate = "";
        var loanPaymentPeriod = "";
        
        public string getLoanPrinciple() { return loanPrinciple; }

        public string getLoanInterestRate() { return loanInterestRate; }

        public string getLoanPaymentPeriod() { return loanPaymentPeriod; }

        private void setLoanPrinciple(string newLoanPrinciple) { loanPrinciple = newLoanPrinciple; }

        private void setLoanInterestRate(string newLoanInterestRate) { loanInterestRate = newLoanInterestRate; }

        private void setLoanPaymentPeriod(string newLoanPaymentPeriod) { loanPaymentPeriod = newLoanPaymentPeriod; }

        public int calculatePayments(string loanPrinciple, string loanInterestRate, string loanPaymentPeriod)
        {
            int paymentDue = 0;
            return paymentDue;
        }

    }

}