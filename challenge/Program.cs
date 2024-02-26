using System;

/* 
 Write a C# program for a small cafe that calculates the total price of items ordered by a customer. 
The cafe offers coffee, tea, and pastries. Each item has a fixed price. The program should prompt the 
user to enter the quantity of each item ordered. Once the quantities are entered, calculate and display 
the total price including tax (assume a fixed tax rate). Use arrays to store item names and prices.
 
 */

class Program
{
    static void Main(string[] args)
    {
        // Define item names and prices
        string[] items = { "Coffee", "Tea", "Pastry" };
        double[] prices = { 2.5, 2.0, 3.0 }; // Prices in dollars

        // Define tax rate
        const double taxRate = 0.1; // 10% tax

        // Initialize total price
        double totalPrice = 0;

        // Display menu
        Console.WriteLine("Menu:");
        for (int i = 0; i < items.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i]} - ${prices[i]} each");
        }

        // Prompt user for quantity of each item
        for (int i = 0; i < items.Length; i++)
        {
            Console.Write($"Enter quantity of {items[i]}: ");
            int quantity = int.Parse(Console.ReadLine());

            // Calculate subtotal for each item and update total price
            double subtotal = quantity * prices[i];
            totalPrice += subtotal;
        }

        // Calculate total price including tax
        double totalWithTax = totalPrice * (1 + taxRate);

        // Display total price
        Console.WriteLine($"Total price (including tax): ${totalWithTax:F2}");
    }
}
