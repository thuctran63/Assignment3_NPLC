using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Exercise2
{
    class Main
    {
        private static List<Student> students = new List<Student>();

        public static void main()
        {
            int choice = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Input student");
                Console.WriteLine("2. Display student");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        InputData();
                        break;
                    case 2:
                        DisplayStudent();
                        break;

                }
            }
        }

        private static void InputData()
        {
            bool check = true;
            while (check)
            {
                Console.Clear();
                Console.Write("Enter student name: ");
                string name = Console.ReadLine();
                Console.Write("Enter student class: ");
                string @class = Console.ReadLine();
                Console.Write("Enter gender: ");
                string gender = Console.ReadLine();
                Console.Write("Enter entry date: ");
                DateTime entryDate;
                DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out entryDate);
                Console.Write("Enter age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter address: ");
                string address = Console.ReadLine();
                Console.Write("Enter relationship: ");
                string relationship = Console.ReadLine();
                Console.Write("Enter mark: ");
                decimal mark = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Enter grade: ");
                string grade = Console.ReadLine();

                Student student = new Student(name, @class, gender, entryDate, age, address, relationship, mark, grade);
                students.Add(student);
               
                Console.WriteLine("Add student successfully! Do you want to add more? (Y/N)");
                string? answer = Console.ReadLine();

                if (answer.ToUpper() == "N")
                {
                    check = false;
                }
            }
        }

        private static void DisplayStudent()
        {
            Console.Clear();
            Console.WriteLine("Name\tClass\tGender\tRelationship\tAge\tGrade\n");

            foreach(var s in students)
            {
                Console.WriteLine(s.ToString());
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
