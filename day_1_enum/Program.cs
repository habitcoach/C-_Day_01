using System;

namespace day_1_enum
{
    // Declare an enum for different days of the week
    enum DayOfWeek
    {
        Sunday=,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enum Demo: Days of the Week");

            // Accessing enum values
            DayOfWeek today = DayOfWeek.Wednesday;
            

           

            Console.WriteLine($"Today is {today}");

            Console.WriteLine($"Today is {(int)today}");

            //// Using enums in switch statements
            //switch (today)
            //{
            //    case DayOfWeek.Sunday:
            //        Console.WriteLine("It's Sunday! Time to relax.");
            //        break;
            //    case DayOfWeek.Saturday:
            //        Console.WriteLine("It's Saturday! Enjoy the weekend.");
            //        break;
            //    default:
            //        Console.WriteLine("It's a weekday. Work hard!");
            //        break;
            //}

            //// Enum iteration
            //Console.WriteLine("All the days of the week:");

            //foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
            //{
            //    Console.WriteLine(day);
            //}

         //  foreach(datatye variable in [])
        }
    }
}
