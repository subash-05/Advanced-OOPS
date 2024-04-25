using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleInheritance1
{
    //enum declaration
    public enum GenderEnum {Select, Male, Female}
    public class PersonalInfo
    {
        //properties
        public string Name {get; set;}
        public string FatherName {get; set;}
        public long Phone {get; set;}
        public string Mail {get; set;}
        public DateTime DOB {get; set;}
        public GenderEnum Gender {get; set;}

        //constructor
        public PersonalInfo(string name, string fatherName, long phone, string mail, DateTime dob, GenderEnum gender)
        {
            Name = name;
            FatherName = fatherName;
            Phone = phone;
            Mail = mail;
            DOB = dob;
            Gender = gender;
        }
    }
}