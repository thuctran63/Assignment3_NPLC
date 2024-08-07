using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Exercise1
{
    public abstract class Employee : Interface
    {
        public string Ssn { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BirthDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        // constructor
        public Employee(string ssn, string firstName, string lastName, string birthDate, string phone, string email)
        {
            Ssn = ssn;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Phone = phone;
            Email = email;
        }

        public Employee() { }


        // method

        public override string ToString()
        {
            return $"SSN: {Ssn}\tFirst Name: {FirstName}\tLast Name: {LastName}\tBirth Date: {BirthDate}\tPhone: {Phone}\tEmail: {Email}";
        }

        public double GetPaymentAmount()
        {
            return 0.0;
        }
    }
}
