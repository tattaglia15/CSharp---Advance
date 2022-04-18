using System;
using System.Collections.Generic;

namespace C_Advance_Class__02__HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dog firstDog = new Dog(0, "H", "");
            Dog secondDog = new Dog(5, "Barky", "Red");
            Dog thirdDog = new Dog(2, "Speedy", "Brown");
            Dog.Validate(firstDog);
            List<Dog> Mydogs = new List<Dog>
            { 
                secondDog,
                thirdDog
            };
            DogShelter.PrinAll(Mydogs);
        }
    }
}
