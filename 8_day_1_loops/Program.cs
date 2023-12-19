using System;

using System;

class Program
{
    static void Main()
    {
        // Creating an array of integers
        int[] myArray = { 1, 2, 3, 4, 5 };

        // Printing array elements using a while loop
        Console.WriteLine("Printing array elements using a while loop:");
        int i = 0;
        while (i < myArray.Length)
        {
            Console.WriteLine(myArray[i]);
            i++;
        }

        // Printing array elements using a do-while loop
        Console.WriteLine("\nPrinting array elements using a do-while loop:");
        i = 0;
        do
        {
            Console.WriteLine(myArray[i]);
            i++;
        } while (i < myArray.Length);

        // Printing array elements using a for loop
        Console.WriteLine("\nPrinting array elements using a for loop:");
        for (int j = 0; j < myArray.Length; j++)
        {
            Console.WriteLine(myArray[j]);
        }

        foreach (var item in myArray) {
            Console.WriteLine(myArray[item]);
        }

        foreach (int it in myArray) {
            if (it <= 5)
            {
                Console.Write(myArray[it]);
            } else { break; }
        }

        
    }
}
