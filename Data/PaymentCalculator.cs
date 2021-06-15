using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoanSystem.Data
{
    public class PaymentCalculator
    {
        //Returns a PaymentCalculation Object
        public static PaymentCalculation calculatePayments(List<Loan> LoanArray)
        {
            PaymentCalculation calculation = new PaymentCalculation();
            int numMonths = 24;
            calculation.setMonthsDisplayed(numMonths);
            int firstStartDate = LoanArray[0].start;
            //Find the earliest loan start date
            for (int i = 1; i < LoanArray.Count; i++)
            {
                int currDate = LoanArray[i].start;
                if (currDate < firstStartDate) { firstStartDate = currDate; }
            }

            double[] totalOwed = new double[numMonths];
            double[] principalOwed = new double[numMonths];
            double[] interestOwed = new double[numMonths];

            for (int i = 0; i < numMonths; i++)
            {
                for (int j = 0; j < LoanArray.Count; j++)
                {
                    if (firstStartDate <= LoanArray[j].start)
                    {
                        principalOwed[i] += Math.Round(((double)LoanArray[j].principle / (double)LoanArray[j].length), 2);
                        interestOwed[i] += Math.Round((principalOwed[i] * (((double)LoanArray[j].rate) / 100)), 2);
                    }
                }
                totalOwed[i] += (principalOwed[i] + interestOwed[i]);
            }
            calculation.setMonthsDisplayed(numMonths);
            calculation.setTotalAmountOwed(totalOwed);
            calculation.setTotalPrincipalOwed(principalOwed);
            calculation.setTotalInterestOwed(interestOwed);

            return calculation;
        }
    }

}