using System;

namespace day_1_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arithmetic operators
            int a = 10, b = 5;

            int additionResult = a + b;
            int subtractionResult = a - b;
            int multiplicationResult = a * b;
            int divisionResult = a / b;
            int modulusResult = a % b;

            // Relational operators
            bool isEqual = a == b;        
            bool isNotEqual = a != b;
            bool isGreaterThan = a > b;
            bool isLessThan = a < b;
            bool isGreaterOrEqual = a >= b;
            bool isLessOrEqual = a <= b;

            
            // Logical operators
            bool isTrue = true;
            bool isFalse = false;
            bool logicalAnd = isTrue && isFalse;
            bool logicalOr = isTrue || isFalse;
            bool logicalNot = !isTrue;

            // Increment and Decrement operators
            int num = 5;
            
            var number = ++num;
            Console.WriteLine("**********"+number);
            var number02 = num++;
            Console.WriteLine("*********"+ number02);

           
            int incrementedNum = num;
            num--;
            int decrementedNum = num;

            // C
            //C++
            //C++
            // ++

            // Assignment operators
            int x = 10;

            x += 5; // Equivalent to x = x + 5;
            x -= 3; // Equivalent to x = x - 3;
            x *= 2; // Equivalent to x = x * 2;
            x /= 4; // Equivalent to x = x / 4;
            x %= 3; // Equivalent to x = x % 3;

            // Bitwise operators
            int binaryA = 5;  // Binary representation: 0000 0101
            int binaryB = 3;  // Binary representation: 0000 0011

            int bitwiseAndResult = binaryA & binaryB;   // Bitwise AND: 0000 0001 (Decimal 1)
            int bitwiseOrResult = binaryA | binaryB;    // Bitwise OR: 0000 0111 (Decimal 7)
            int bitwiseXorResult = binaryA ^ binaryB;   // Bitwise XOR: 0000 0110 (Decimal 6)
            int bitwiseNotResult = ~binaryA;            // Bitwise NOT: 1111 1010 (Decimal -6)

            // Display the results
            Console.WriteLine("Arithmetic Operators:");
            Console.WriteLine($"Addition: {additionResult}");
            Console.WriteLine($"Subtraction: {subtractionResult}");
            Console.WriteLine($"Multiplication: {multiplicationResult}");
            Console.WriteLine($"Division: {divisionResult}");
            Console.WriteLine($"Modulus: {modulusResult}");

            Console.WriteLine("\nRelational Operators:");
            Console.WriteLine($"Equal: {isEqual}");
            Console.WriteLine($"Not Equal: {isNotEqual}");
            Console.WriteLine($"Greater Than: {isGreaterThan}");
            Console.WriteLine($"Less Than: {isLessThan}");
            Console.WriteLine($"Greater Or Equal: {isGreaterOrEqual}");
            Console.WriteLine($"Less Or Equal: {isLessOrEqual}");

            Console.WriteLine("\nLogical Operators:");
            Console.WriteLine($"Logical AND: {logicalAnd}");
            Console.WriteLine($"Logical OR: {logicalOr}");
            Console.WriteLine($"Logical NOT: {logicalNot}");

            Console.WriteLine("\nIncrement and Decrement Operators:");
            Console.WriteLine($"Incremented Num: {incrementedNum}");
            Console.WriteLine($"Decremented Num: {decrementedNum}");

            Console.WriteLine("\nAssignment Operators:");
            Console.WriteLine($"x: {x}");

            Console.WriteLine("\nBitwise Operators:");
            Console.WriteLine($"Bitwise AND: {bitwiseAndResult}");
            Console.WriteLine($"Bitwise OR: {bitwiseOrResult}");
            Console.WriteLine($"Bitwise XOR: {bitwiseXorResult}");
            Console.WriteLine($"Bitwise NOT: {bitwiseNotResult}");
        }
    }
}
