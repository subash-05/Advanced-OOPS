using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualFunctions2
{
    public class Sphere : Dimention
    {
        //field
        private double _radius = 23;
        //property
        public double Radius {get{return _radius;} set{_radius = value;}}

        //methods
        public override double Calculate()
        {
            return 4 * 3.14 * Radius * Radius;
        }
        public void DisplayArea()
        {
            Console.WriteLine($"Area of sphere: {Calculate()}");
        }
    }
}