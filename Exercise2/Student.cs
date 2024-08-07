using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3.Exercise2
{
    class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public string Gender { get; set; }
        public string Relationship { get; set; }
        public DateTime EntryDate { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public decimal Mark { get; set; }
        public string Grade { get; set; }

        public Student(
        string name,
        string @class,
        string gender,
        DateTime entryDate,
        int age,
        string address,
        string relationship = "Single",
        decimal mark = 0,
        string grade = "F")
        {
            Name = name;
            Class = @class;
            Gender = gender;
            EntryDate = entryDate;
            Age = age;
            Address = address;
            Relationship = relationship;
            Mark = mark;
            Grade = grade;
        }

        public void SetGrade(double GradePoint = 0)
        {
            switch (GradePoint)
            {
                case 0:
                    this.Grade = "F";
                    break;
                case 1:
                    this.Grade = "D";
                    break;
                case 2:
                    this.Grade = "C";
                    break;
                case 2.3:
                    this.Grade = "C+";
                    break;
                case 2.7:
                    this.Grade = "B-";
                    break;
                case 3:
                    this.Grade = "B";
                    break;
                case 3.3:
                    this.Grade = "B+";
                    break;
                case 3.7:
                    this.Grade = "A-";
                    break;
                case 4:
                    this.Grade = "A";
                    break;
            }
        }

        public void SetGrade()
        {
            this.Grade = "F";
        }

        public override string ToString()
        {
            
            return $"{Name}\t{Class}\t{Gender}\t{Relationship}\t{Age}\t{Grade}";
            
        }
    }
}
