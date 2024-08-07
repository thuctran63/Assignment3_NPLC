using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Exercise1
{
    public class SalaryEmployee : Employee
    {
        public double CommissionRate { get; set; }
        public double GrossSales { get; set; }
        public double BasicSalary { get; set; }

        public SalaryEmployee(string ssn, string firstName, string lastName, string birthDate, string phone, string email, double commissionRate, double grossSales, double basicSalary) : base(ssn, firstName, lastName, birthDate, phone, email)
        {
            CommissionRate = commissionRate;
            GrossSales = grossSales;
            BasicSalary = basicSalary;
        }

        public SalaryEmployee() { }

        public override string ToString()
        {
            return base.ToString() + $"\tCommission Rate: {CommissionRate}" + $"\tGross Sales: {GrossSales}";
        }
    }
}
