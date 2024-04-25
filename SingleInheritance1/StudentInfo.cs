using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance1
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
        public StudentInfo(string name, string fatherName, long phone, string mail, DateTime dob, GenderEnum gender, string standard, string branch, int academicYear) : base(name, fatherName, phone, mail, dob, gender)
        {
            s_registerNumber++;
            RegisterNumber = "RN" + s_registerNumber;

            Standard = standard;
            Branch = branch;
            AcademicYear = academicYear;
        }
    }
}