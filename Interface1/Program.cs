using System;
namespace Interface1;

class Program
{
    public static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.Name = "Doberman";
        dog.Habitat = "Lands";
        dog.EatingHabit = "Food";

        Duck duck = new Duck();
        duck.Name = "Duck";
        duck.Habitat = "Pond";
        duck.EatingHabit = "Seed";

        dog.DisplayName();
        duck.DisplayName();
    }
}