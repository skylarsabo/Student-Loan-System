using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoanTest
{
    class PaymentCalculator
    {
        //Returns a PaymentCalculation Object
        public static PaymentCalculation calculatePayments(StudentLoan[] LoanArray)
        {
            PaymentCalculation calculation = new PaymentCalculation();

            int numMonths = 12; //Make this a method argument
            calculation.setMonthsDisplayed(numMonths);
            int firstStartDate = LoanArray[0].getLoanPaymentPeriodStartDate();
            //Find the earliest loan start date
            for (int i = 1; i < LoanArray.Length; i++)
            {
                int currDate = LoanArray[i].getLoanPaymentPeriodStartDate();
                if (currDate < firstStartDate) { firstStartDate = currDate; }
            }

            double[] totalOwed = new double[12];
            double[] principalOwed = new double[12];
            double[] interestOwed = new double[12];

            for (int i = 0; i < numMonths; i++)
            {
                for (int j = 0; j < LoanArray.Length; j++)
                {
                    if (firstStartDate <= LoanArray[j].getLoanPaymentPeriodStartDate())
                    {
                        principalOwed[i] += ((double)LoanArray[j].getLoanPrinciple() / (double)LoanArray[j].getLoanPaymentPeriodLength());
                        interestOwed[i] += (principalOwed[i] * (((double)LoanArray[j].getLoanInterestRate()) / 100));
                    }
                }
                totalOwed[i] += (principalOwed[i] + interestOwed[i]);
            }
            calculation.setTotalAmountOwed(totalOwed);
            calculation.setTotalPrincipalOwed(principalOwed);
            calculation.setTotalInterestOwed(interestOwed);

            return calculation;
        }
    }
}