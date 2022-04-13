using System;

namespace Class_01___Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Please enter Date example mm/dd/yy");
                string enterDate = Console.ReadLine();
                DateTime dates;
                bool validate = DateTime.TryParse(enterDate, out dates);
                if (!validate)
                {
                    Console.WriteLine("The Date is Incorrect, Try Again!");
                }
                else
                {
                    Console.WriteLine("The Date is Correct");
                }
                if (
                dates.Month == 1 && dates.Day == 1 ||
                dates.Month == 1 && dates.Day == 7 ||
                dates.Month == 4 && dates.Day == 20 ||
                dates.Month == 5 && dates.Day == 1 ||
                dates.Month == 8 && dates.Day == 8 ||
                dates.Month == 10 && dates.Day == 12 ||
                dates.Month == 10 && dates.Day == 23 ||
                dates.Month == 12 && dates.Day == 8
                )
                {
                    Console.WriteLine("These are non working days also");
                }
                else if (dates.Day == 1 || dates.Day == 2 || dates.Day == 3 || dates.Day == 4 || dates.Day == 5)
                {
                    Console.WriteLine("Working Days");
                }
                else if (dates.Day == 6 || dates.Day == 7)
                {
                    Console.WriteLine("These are weekends");
                }
                else
                {
                    Console.WriteLine("You must enter from 1 to 7 day if you want to check if is work or weekend day");
                }  

            //switch(dates.Day)
            //{
            //    case 1:
            //    case 2:
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("Working Days");
            //        break;
            //    case 6:
            //    case 7:
            //        Console.WriteLine("These are Weekends");
            //        break;
            //    default:
            //        Console.WriteLine("You must enter from 1 to 7 day to check if is working day or not");
            //        break;
            //}


        }
    }
}
