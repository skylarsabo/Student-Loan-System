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
    class RiskCalculator
    {
        var studentCreditScore = "";
        var studentReferences = "";
        var studentInformation = "";

        public string getStudentCreditScore() { return studentCreditScore; }

        public string getStudentReferences() { return studentReferences; }

        public string getStudentInformation() { return studentInformation; }

        private void setStudentCreditScore(string newStudentCreditScore) { studentCreditScore = newStudentCreditScore; }

        private void setStudentReferences(string newStudentReferences) { studentReferences = newStudentReferences; }

        private void setStudentInformation(string newStudentInformation) { studentInformation = newStudentInformation; }

        public int calculateRisk(string studentCreditScore, string studentReferences, string studentInformation)
        {
            int calculatedRisk = 0;
            return calculatedRisk;
        }

    }

}