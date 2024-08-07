using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Exercise1
{
    public class Department
    {
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; }

        public Department(string departmentName, List<Employee> employees)
        {
            DepartmentName = departmentName;
            Employees = employees;
        }

        public Department() { }
        public Department(string departmentName)
        {
            DepartmentName = departmentName;
            Employees = new List<Employee>();
        }


        public List<T> GetEmployees<T>() where T : Employee
        {
            return Employees.OfType<T>().ToList();
        }

        public int CountOf<T>() where T : Employee
        {
            return Employees.OfType<T>().Count();
        }
    }
}
