using System;
using System.Collections.Generic;

namespace HomeWork___C_Advance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Names:");
            List<string> inputs = new List<string>();

            bool myInput = true;
            while(myInput)
            {
                string input = Console.ReadLine();
                if(input == "x")
                {
                    Console.WriteLine("You Enter x To Shut Down Program");
                    break;
                }
              inputs.Add(input);
            }
            Console.WriteLine("Please Enter a sentence:");
            string[] sentence = Console.ReadLine().Split(' ');
            int counter = 0;
            foreach(string input in inputs)
            {
                foreach(string sentence2 in sentence)
                {
                    if(sentence2.ToLower() == input.ToLower())
                    {
                        counter++;  
                    }
                };
            }
            Console.WriteLine($"The number of names contained in sentence is : {counter}");
        }
    }
}
