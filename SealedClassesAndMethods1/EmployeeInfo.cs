using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedClassesAndMethods1
{
    public sealed class EmployeeInfo
    {
        //properties
        public string UserID {get;}
        public string Password {get; set;}
        public int KeyInfo {get; set;}

        //constructor
        public EmployeeInfo(string password, int keyInfo)
        {
            Password = password;
            KeyInfo = keyInfo;
        }

        //methods
        public void UpdateInfo()
        {

        }
        public void DisplayInfo()
        {

        }
    }
}