using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultilevelInheritance1
{
    public class HSCDetails : StudentInfo
    {
        //field
        private static int s_marksheetNumber = 3000;

        //properties
        public string MarksheetNumber {get;}
        public int Physics {get; set;}
        public int Chemistry {get; set;}
        public int Maths {get; set;}
        public int Total {get; set;}
        public int Percentage {get; set;}

        //constructor
        public HSCDetails(string regno, string name, string fatherName, string phone, string mail, DateTime dob, GenderEnum gender, string standard, string branch, int academicYear, int physics, int chemistry, int maths) : base(regno, name, fatherName, phone, mail, dob, gender, standard, branch, academicYear)
        {
            s_marksheetNumber++;
            MarksheetNumber = "MS" + s_marksheetNumber;

            Physics = physics;
            Chemistry =chemistry;
            Maths = maths;
        }

        public void GetMarks()
        {
            
        }

        public void Calculate()
        {
            int total = Physics + Chemistry + Maths;
            int percentage = total / 3;
            Console.WriteLine("Student Marksheet");
            Console.WriteLine($"Marksheet Number: {MarksheetNumber}");
            Console.WriteLine($"Total: {total}");
            Console.WriteLine($"Percentage: {percentage}");
        }
    }
}