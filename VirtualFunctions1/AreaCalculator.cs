using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualFunctions1
{
    public class AreaCalculator
    {
        //properties
        public double Radius {get; set;}

        //method
        public virtual double Calculate(double Radius)
        {
            return 3.14 * Radius * Radius;
        }
    }
}