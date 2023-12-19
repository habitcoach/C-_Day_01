using System;

namespace day1_LogicalAndOr
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = "ranjith";
            string password = "password";
           // bool isDayTime = DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 18; // Assume day time is between 6 AM and 6 PM

            Console.WriteLine("Welcome to the Security System Demo!");

            Console.Write("Enter your username: ");
            string enteredUsername = Console.ReadLine();

            Console.Write("Enter your password: ");
            string enteredPassword = Console.ReadLine();

            if (enteredUsername == username && enteredPassword == password)
            {
                Console.WriteLine("Access granted! You can enter the restricted area.");
            }
            else if (enteredUsername == username && enteredPassword == password)
            {
                Console.WriteLine("Access granted! But please note that it's currently outside the allowed time range.");
            }
            else
            {
                Console.WriteLine("Access denied! Incorrect username, password, or not authorized during this time.");
            }

        }
    }
}

