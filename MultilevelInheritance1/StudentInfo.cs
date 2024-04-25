using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance1
{
    public class StudentInfo : PersonalInfo
    {
        //field
        private static int s_registerNumber = 1000;

        //properties
        public string RegisterNumber {get;}
        public string Standard {get; set;}
        public string Branch {get; set;}
        public int AcademicYear {get; set;}

        //Constructor
        public StudentInfo(string name, string fatherName, string phone, string mail, DateTime dob, GenderEnum gender, string standard, string branch, int academicYear) : base(name, fatherName, phone, mail, dob, gender)
        {
            s_registerNumber++;
            RegisterNumber = "RN" + s_registerNumber;

            Standard = standard;
            Branch = branch;
            AcademicYear = academicYear;
        }

        public StudentInfo(string regno, string name, string fatherName, string phone, string mail, DateTime dob, GenderEnum gender, string standard, string branch, int academicYear) : base(name, fatherName, phone, mail, dob, gender)
        {
            RegisterNumber = regno;
            Standard = standard;
            Branch = branch;
            AcademicYear = academicYear;
        }

        //method
        public void GetStudentInfo()
        {

        }
        public void ShowInfo()
        {
            Console.WriteLine("Student Information: ");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Standard: {Standard}");
            Console.WriteLine($"Branch: {Branch}");
            Console.WriteLine($"AcademicYear: {AcademicYear}");
        }
    }
}