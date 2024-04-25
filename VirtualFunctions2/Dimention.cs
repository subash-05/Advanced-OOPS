using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualFunctions2
{
    public class Dimention
    {
        //properties
        public int Value1 {get; set;}
        public int Value2 {get; set;}

        //methods
        public virtual double Calculate()
        {
            return Value1 * Value2;
        }

        public void Display()
        {
            Console.WriteLine($"Area: {Calculate()}");
        }
    }
}