using System;
namespace VirtualFunctions2;

class Program
{
    public static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();
        Sphere sphere = new Sphere();

        rectangle.DisplayArea();

        sphere.DisplayArea();
    }
}