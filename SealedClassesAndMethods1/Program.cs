using System;
namespace SealedClassesAndMethods1;

class Program
{
    public static void Main(string[] args)
    {
        EmployeeInfo employee = new EmployeeInfo("pass1234", 100);

        Hack hack = new Hack();
        Console.WriteLine(hack.KeyInfo);
    }
}