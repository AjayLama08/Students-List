using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_List
{
    public class Student
    {
        public Student()
        {
            Forename = "Unknown";
            Surname = "Unknown";
            Age = 0;
            Course = "Unknown";
            Mark = 0.0;
            EnrolmentYear = 0;
        }
        public Student(string forename, string surname, int age, string course, double mark, int enrolementYear)
        {
            Forename = forename;
            Surname = surname;
            Age = age;
            Course = course;
            Mark = mark;
            EnrolmentYear = enrolementYear;
        }
        public override string ToString()
        {
            return $"Name: {Forename} {Surname}, Age: {Age}, Course: {Course}, Mark: {Mark}, Enrolment Year: {EnrolmentYear}";
        }

        public string Forename { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }
        public double Mark { get; set; }
        public int EnrolmentYear { get; set; }

    }
}

