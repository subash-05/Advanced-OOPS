using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualFunctions1
{
    public class VolumeCalculator : AreaCalculator
    {
        //field
        private int _height = 13;
        //properties
        public double Height {get{return _height;} set{value = _height;}}

        //override method
        public override double Calculate(double Radius)
        {
            return 3.14*Radius*Radius*Height;
        }
    }
}