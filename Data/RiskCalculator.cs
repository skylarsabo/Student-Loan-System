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
    class RiskCalculator
    {
        public static bool calculateRisk(int creditScore, int yearlyIncome, int amount, int accountBalance)
        {
            int expectedPayoffTime = (amount = accountBalance) / yearlyIncome;
            if (expectedPayoffTime <= 10 && creditScore >= 600)
                return true;
            return false;
        }

    }
}