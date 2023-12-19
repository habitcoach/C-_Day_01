using System;

public class Program {


    public static void Main(string[] args) {

        // One-Dimensional Array Example
        int[] oneDimensionalArray = { 1, 2, 3, 4, 5 };

       

        // Accessing elements in the 1D array
        Console.WriteLine("One Dimension");  // Output: 1
        Console.WriteLine(oneDimensionalArray[0]);  // Output: 1
        Console.WriteLine(oneDimensionalArray[3]);  // Output: 4
        Console.WriteLine(oneDimensionalArray[4]);  // Output: 5


        // Two-Dimensional Array Example
        int[,] twoDimensionalArray = {
                                       { 1, 2, 3 },
                                       { 4, 5, 6 },
                                       { 7, 8, 9 }
                                     };

        int[,] threedimarray = { };

        // Accessing elements in the 2D array
        Console.WriteLine("Two Dimension");
        Console.WriteLine(twoDimensionalArray[0, 0]);  // Output: 1
        Console.WriteLine(twoDimensionalArray[1, 2]);  // Output: 6
        Console.WriteLine(twoDimensionalArray[2, 1]);  // Output: 8



        // Jagged Array Example
        int[][] jaggedArray = new int[][] {
                                         new int[] { 1, 2, 3 },
                                         new int[] { 4, 5 },
                                         new int[] { 6, 7, 8, 9 },
                                         new int[] { 10 }
                                          };

        // Accessing elements in the jagged array
        Console.WriteLine("Jagged array");
        Console.WriteLine(jaggedArray[0][1]);  // Output: 2
        Console.WriteLine(jaggedArray[1][0]);  // Output: 4
        Console.WriteLine(jaggedArray[2][2]);  // Output: 8
        Console.WriteLine(jaggedArray[3][0]);  // Output: 10




    }

}