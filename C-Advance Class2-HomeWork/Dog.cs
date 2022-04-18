using System;


namespace C_Advance_Class__02__HomeWork
{
    internal class Dog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }

        public void Bark()
        {
            Console.WriteLine("Bark bark");
        }
        public Dog(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }
        public static void Validate(Dog dog)
        {
            if(dog.Id <= 0)
            {
                Console.WriteLine("Id must be greater than 0");
            }
            if(dog.Color == "" )
            {
                Console.WriteLine("You must enter a Color");
            }
            if(dog.Name.Length <= 2 )
            {
                Console.WriteLine("Name Must be Longer Than 2 Char");
            } 
            else
            {
                Console.WriteLine($"Dog name {dog.Name} Dog Id: {dog.Id} Dog Color: {dog.Color}");
            }
        }
    }
}
