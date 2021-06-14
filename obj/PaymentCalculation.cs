using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentLoanTest
{
    class PaymentCalculation
    {
        int monthsDisplayed;
        double[] totalAmountOwed;
        double[] totalPrincipalOwed;
        double[] totalInterestOwed;

        public PaymentCalculation(int newMonthsDisplayed, double[] newTotalAmountOwed, double[] newTotalPrincipalOwed, double[] newTotalInterestOwed)
        {
            monthsDisplayed = newMonthsDisplayed;
            totalAmountOwed = newTotalAmountOwed;
            totalPrincipalOwed = newTotalPrincipalOwed;
            totalInterestOwed = newTotalInterestOwed;
        }

        public PaymentCalculation()
        {
            monthsDisplayed = 0;
            totalAmountOwed = new double[0];
            totalPrincipalOwed = new double[0];
            totalInterestOwed = new double[0];
        }

        public int getMonthsDisplayed() { return monthsDisplayed; }

        public double[] getTotalAmountOwed() { return totalAmountOwed; }

        public double[] getTotalPrincipalOwed() { return totalPrincipalOwed; }

        public double[] getTotalInterestOwed() { return totalInterestOwed; }

        public void setMonthsDisplayed(int newMonthsDisplayed) { monthsDisplayed = newMonthsDisplayed; }

        public void setTotalAmountOwed(double[] newTotalAmountOwed) { totalAmountOwed = newTotalAmountOwed; }

        public void setTotalPrincipalOwed(double[] newTotalPrincipalOwed) { totalPrincipalOwed = newTotalPrincipalOwed; }

        public void setTotalInterestOwed(double[] newTotalInterestOwed) { totalInterestOwed = newTotalInterestOwed; }

        public String testOutput()
        {
            double sumAmountOwed = totalAmountOwed.Sum();
            double sumPrincipalOwed = totalPrincipalOwed.Sum();
            double sumInterestOwed = totalInterestOwed.Sum();
            String output = "Months Displayed: " + monthsDisplayed.ToString() + "\nTotal Amount Owed: $" + sumAmountOwed.ToString("N2") + "\nTotal Principal Owed: $" + sumPrincipalOwed.ToString("N2") + "\nTotal Interest Owed: $" + sumInterestOwed.ToString("N2");
            return output;
        }
    }
}