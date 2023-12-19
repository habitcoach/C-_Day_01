using System;

namespace day1_Rational_datatype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Baking a cake");
            Console.WriteLine("**************");

            //decimal
            //higher significant digit hence higher precision 

            decimal vanillaExtractCost = 10.55M; // The cost of vanilla extract per milliliter
            decimal saffronCost = 27.99M; // The cost of saffron per gram

            decimal vanillaExtractAmount = 25.75M; // Milliliters
            decimal saffronAmount = 0.25M; // Grams

            decimal totalCost = (vanillaExtractCost * vanillaExtractAmount) + (saffronCost * saffronAmount);
            Console.WriteLine("The cost of these critical ingredients is $" + totalCost);
            Console.WriteLine();


            
            //float

            float milkAmount = 500.25f; // Milliliters
            float sugarAmount = 250.50f; // Grams

            float totalLiquid = milkAmount + 50.75f; // Adding 50.75 milliliters for flavoring
            float totalDry = sugarAmount - 25.25f; // Subtracting 25.25 grams for a special diet

            Console.WriteLine("The adjusted milk  is " + totalLiquid + " milliliters");
            Console.WriteLine("The adjusted sugar  is " + totalDry + " grams");
            Console.WriteLine();

            //double

            double flourAmount = 750.85; // Grams
            double bakingPowderAmount = 2.5; // Teaspoons

            double flourForCake = flourAmount - 50.35; // Subtracting 50.35 grams for a smaller cake
            double bakingPowderForCake = bakingPowderAmount * 0.75; // Using 75% of the original amount

            Console.WriteLine("The flour  for the cake is " + flourForCake + " grams");
            Console.WriteLine("The baking powder for the cake is " + bakingPowderForCake + " teaspoons");
        }





    }
    
}

