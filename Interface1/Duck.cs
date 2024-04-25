using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interface1
{
    public class Duck : IAnimal
    {
        public string Name {get; set;}
        public string Habitat {get; set;}
        public string EatingHabit {get; set;}

        //method
        public void DisplayName()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Habitat);
            Console.WriteLine(EatingHabit);
        }
    }
}