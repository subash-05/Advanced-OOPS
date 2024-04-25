using System;
namespace SingleInheritance1;

class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo personalInfo = new PersonalInfo("Niko","Bellic",9876543210,"niko@gmail.com",new DateTime(1999,11,02),GenderEnum.Male);
        

        StudentInfo student1 = new StudentInfo(personalInfo.Name, personalInfo.FatherName, personalInfo.Phone, personalInfo.Mail, personalInfo.DOB, personalInfo.Gender, "XII", "Computer Science", 2018);
        StudentInfo student2 = new StudentInfo("Batman", "Wayne", 7986543210, "batman@gmail.com", new DateTime(1987,12,11), GenderEnum.Male, "X", "Computer Science", 2005);

        Console.WriteLine($"Student 1\nName: {student1.Name}\nFatherName: {student1.FatherName}\nPhone Number: {student1.Phone}\nMail ID: {student1.Mail}\nDate of Birth: {student1.DOB}\nGender: {student1.Gender}\nStandard: {student1.Standard}\nBranch: {student1.Branch}\nAcademic year: {student1.AcademicYear}\nRegistration Number: {student1.RegisterNumber}\n");
        Console.WriteLine($"Student 2\nName: {student2.Name}\nFatherName: {student2.FatherName}\nPhone Number: {student2.Phone}\nMail ID: {student2.Mail}\nDate of Birth: {student2.DOB}\nGender: {student2.Gender}\nStandard: {student2.Standard}\nBranch: {student2.Branch}\nAcademic year: {student2.AcademicYear}\nRegistration Number: {student2.RegisterNumber}\n");
    }
}