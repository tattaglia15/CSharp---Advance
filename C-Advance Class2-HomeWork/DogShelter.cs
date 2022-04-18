using System;
using System.Collections.Generic;
using System.Text;

namespace C_Advance_Class__02__HomeWork
{
    internal static class DogShelter
    {
        public static List<Dog> Dogs = new List<Dog>();
        public static void PrinAll(List<Dog> dogs)
        {
            foreach (Dog dog in dogs)
            {
                Console.WriteLine($"Dog Name: {dog.Name} Dog id: {dog.Id} Dog Color Is: {dog.Color}");
            }
        }
    }
}
