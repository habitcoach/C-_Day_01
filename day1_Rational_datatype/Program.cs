using System;

namespace DataTypeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Using decimal for financial calculations where precision is crucial
            decimal itemPrice = 19.99M; // Price of an item in dollars
            decimal taxRate = 0.0825M; // 8.25% tax rate

            decimal totalPrice = itemPrice * (1 + taxRate); // Calculating total price including tax
            Console.WriteLine("Total Price with tax (using decimal): $" + totalPrice);
            Console.WriteLine();

            // Using float for scientific calculations or when memory is a concern
            float piValue = 3.14159f; // Approximate value of pi
            float radius = 5.5f; // Radius of a circle in meters

            float circleArea = piValue * radius * radius; // Calculating area of a circle
            Console.WriteLine("Area of the circle (using float): " + circleArea + " square meters");
            Console.WriteLine();

            // Using double for general-purpose floating point calculations
            double exchangeRate = 1.23; // Exchange rate of USD to EUR
            double usdAmount = 100.0; // Amount in USD

            double eurAmount = usdAmount * exchangeRate; // Converting USD to EUR
            Console.WriteLine("Equivalent amount in EUR (using double): €" + eurAmount);
        }
    }
}
