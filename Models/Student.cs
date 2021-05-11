using System;
using System.ComponentModel.DataAnnotations;

namespace StudentLoanSystem.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }
}