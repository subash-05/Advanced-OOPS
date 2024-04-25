using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualFunctions2
{
    public class Rectangle : Dimention
    {
        //field
        private int _length;
        private int _height;
        //properties
        public int Length {get{return _length;} set{_length = 5;}}
        public int Height {get{return _height;} set{_height = 12;}}

        //constructor
        public Rectangle()
        {
            Length = _length;
            Height  = _height;
        }

        //methods
        public override double Calculate()
        {
            return Length * Height;
        }
        public void DisplayArea()
        {
            double area = Calculate();
            Console.WriteLine($"Area of rectangle: {area}");
        }
    }
}