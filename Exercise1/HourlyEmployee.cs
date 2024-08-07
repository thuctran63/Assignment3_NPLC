using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Exercise1
{
    public class HourlyEmployee : Employee
    {
        public double Wage { get; set; }
        public double Hours { get; set; }

        public HourlyEmployee(string ssn, string firstName, string lastName, string birthDate, string phone, string email, double wage, double hours) : base(ssn, firstName, lastName, birthDate, phone, email)
        {
            Wage = wage;
            Hours = hours;
        }

        public HourlyEmployee() { }

        public override string ToString()
        {
            return base.ToString() + $"\tWage: {Wage}" + $"\tHours: {Hours}";
        }
    }
}
