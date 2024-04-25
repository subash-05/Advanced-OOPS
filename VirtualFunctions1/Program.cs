using System;
namespace VirtualFunctions1;

class Program
{
    public static void Main(string[] args)
    {
        AreaCalculator area = new AreaCalculator();
        VolumeCalculator volume = new VolumeCalculator();

        Console.WriteLine(area.Calculate(5.3));
        Console.WriteLine(volume.Calculate(5.3));
    }
}