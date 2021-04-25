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
    class Student 
    {
        var studentBank = "";
        var studentCreditScore = ""; 
        var studentHomeAddress = ""; 
        var studentID = "";
        var studentName = "";
        var studentPhoneNum = ""; 
        var studentSSN = "";
        var studentUniversity = "";
        var studentLoanID = [];

        public string getBank() { return studentBank; } 

        public string getCreditScore() { return studentCreditScore; }

        public string getHomeAddress() { return studentHomeAddress; }

        public string getStudentID() { return studentID; }

        public string getName() { return studentName; }

        public string getPhoneNum() { return studentPhoneNum; }

        public string getUniversity() { return studentUniversity; }

        public string getLoanID() { return studentLoanID; }

        public string getLoanID(int index) { return studentLoanID[index]; }

        private void setBank(string newBank) { studentBank = newBank; }

        private void setCreditScore(string newCreditScore) { studentCreditScore = newCreditScore; }
        
        private void setHomeAddress(string newHomeAddress) { studentHomeAddress = newHomeAddress; }

        private void setStudentID(string newStudentID) { studentID = newStudentID; }

        private void setStudentName(string newName) { studentName = newName; }

        private void setPhoneNum(string newPhoneNum) { studentPhoneNum = newPhoneNum; }

        private void setUniversity(string newUniversity) { studentUniversity = newUniversity; }

        private void setLoanID(string newLoanID)
        {
            int maxArraySize = 0;
            for (int i = 0; i < studentLoanID.Length; i++)
            {
                maxArraySize += 1;
            }
            Array.Resize(ref studentLoanID, maxArraySize);
            studentLoanID[maxArraySize-1] = newLoanID;
        }

        private void setLoanID(string newLoanID, int index)
        {
            studentLoanID[index] = newLoanID;
        }
   
    }

}