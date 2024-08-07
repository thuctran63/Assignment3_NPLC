using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Exercise1
{
    public static class DepartmentManage
    {
        static List<Department> departments = new List<Department>();
        static List<Employee> employees = new List<Employee>();

        public static void main()
        {
            int choice = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1.Input data");
                Console.WriteLine("2. Display Employee");
                Console.WriteLine("3. Classify Employee");
                Console.WriteLine("4. Employee Search");
                Console.WriteLine("5. Report");
                Console.WriteLine("6. Exit");

                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    InputData();
                }
                else if (choice == 2)
                {
                    DisplayEmployee();
                }
                else if (choice == 3)
                {
                    Classify_Employee();
                }
                else if (choice == 4)
                {
                    Search_Employee();
                }
                else
                {
                    break;
                }
            }
        }

        private static void Search_Employee()
        {
            Console.Clear();

            Console.WriteLine("Enter department name: ");
            string departmentName = Console.ReadLine();
            Department d = departments.Find(d => d.DepartmentName == departmentName);

            if (d == null)
            {
                Console.WriteLine("Department not found");
            }
            else
            {
                foreach (var employee in d.Employees)
                {
                    Console.WriteLine(employee);
                }

                Console.WriteLine("Enter name employee: ");
                string name = Console.ReadLine();
                Employee e = d.Employees.Find(e => e.FirstName == name || e.LastName == name);
                Console.WriteLine(e);

                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            

        }

        private static void Classify_Employee()
        {
            Console.Clear();
            foreach (var employee in employees)
            {
                if (employee is HourlyEmployee)
                {
                    Console.WriteLine("Hourly Employee: ");
                    Console.WriteLine(employee);
                }
                else if (employee is SalaryEmployee)
                {
                    Console.WriteLine("Salary Employee: ");
                    Console.WriteLine(employee);
                }
            }
        }

        private static void DisplayEmployee()
        {
            Console.Clear();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void DisplayDepartment()
        {
            Console.Clear();
            foreach (var department in departments)
            {
                Console.WriteLine(department.DepartmentName);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        private static void AddDepartment()
        {
            Console.Clear();
            Console.WriteLine("Enter Department Name: ");
            string? departmentName = Console.ReadLine();
            Department department = new Department(departmentName);
            departments.Add(department);
        }

        private  static void InputData()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("1. Add Department");
                Console.WriteLine("2. Add Employee");
                Console.WriteLine("0. Quit");

                int choice = Int32.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    AddDepartment();
                }
                else if (choice == 2)
                {
                    AddEmployee();
                }
                else
                {
                    break;
                }
            }
            while (true);
        }


        private static void AddEmployee()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("1. Add Hourly Employee");
                Console.WriteLine("2. Add Salaried Employee");
                Console.WriteLine("0. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Enter SSN: ");
                    string ssn = Console.ReadLine();
                    Console.WriteLine("Enter First Name: ");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Enter Last Name: ");
                    string lastName = Console.ReadLine();
                    Console.WriteLine("Enter Birth Date: ");
                    string birthDate = Console.ReadLine();
                    Console.WriteLine("Enter Phone: ");
                    string phone = Console.ReadLine();
                    Console.WriteLine("Enter Email: ");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter Wage: ");
                    double wage = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Hours: ");
                    double hours = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Department Name: ");
                    string departmentName = Console.ReadLine();

                    HourlyEmployee hourlyEmployee = new HourlyEmployee(ssn, firstName, lastName, birthDate, phone, email, wage, hours);
                    employees.Add(hourlyEmployee);

                    Department deparment = departments.Find(d => d.DepartmentName == departmentName);
                    if (deparment != null)
                    {
                        deparment.Employees.Add(hourlyEmployee);
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter SSN: ");
                    string ssn = Console.ReadLine();
                    Console.WriteLine("Enter First Name: ");
                    string firstName = Console.ReadLine();
                    Console.WriteLine("Enter Last Name: ");
                    string lastName = Console.ReadLine();

                    string birthDate, phone, email;

                    do
                    {
                        Console.WriteLine("Enter Birth Date: ");
                        birthDate = Console.ReadLine();
                    } while (!CheckValidBirthday(birthDate));
                    do
                    {
                        Console.WriteLine("Enter Phone: ");
                        phone = Console.ReadLine();
                    } while (!CheckValidPhone(phone));
                    
                    do
                    {
                        Console.WriteLine("Enter Email: ");
                        email = Console.ReadLine();
                    } while (!CheckValidEmail(email));

                    Console.WriteLine("Enter commistion rate:");
                    double commissionRate = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter gross sales:");
                    double grossSales = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter basic salary:");
                    double basicSalary = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter Department Name: ");
                    string departmentName = Console.ReadLine();

                    SalaryEmployee salariedEmployee = new SalaryEmployee(ssn, firstName, lastName, birthDate, phone, email, commissionRate, grossSales, basicSalary);
                    employees.Add(salariedEmployee);

                    Department? deparment = departments.Find(d => d.DepartmentName == departmentName);
                    if (deparment != null)
                    {
                        deparment.Employees.Add(salariedEmployee);
                    }
                }
                else
                {
                    break;
                }
            }
        }

        // 

        private static bool CheckValidEmail(string email)
        {
            string pattern = @".*@.*\..*";
            if (!System.Text.RegularExpressions.Regex.IsMatch(email, pattern))
            {
                return false;
            }
            return true;
        }

        private static bool CheckValidPhone(string phone)
        {
            string pattern = @"^\d{7}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, pattern))
            {
                return false;
            }
            return true;
        }

        private static bool CheckValidBirthday(string birthday)
        {
            try
            {
                string[] b = birthday.Split('/');
                DateTime date = DateTime.ParseExact(birthday, "d/MM/yyyy", CultureInfo.InvariantCulture);

                if(date > DateTime.Now)
                {
                    Console.WriteLine("Ngày sinh lớn hơn hiện tại");
                    return false;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ngày Sinh không hợp lệ");
                return false;
            }

            return true;
        }
    }
}
