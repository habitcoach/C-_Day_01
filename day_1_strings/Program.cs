using System;
using System.Text;


class StringOperationsDemo
{
    static void Main()
    {
        string originalString = "Hello, World!,";

        Console.WriteLine("Original String: " + originalString);

        // Length of the string
        int length = originalString.Length;

        Console.WriteLine("Length of the String: " + length);

        // Substring
        string subString = originalString.Substring(7, 5);
        Console.WriteLine("Substring: " + subString);

        // ToUpper and ToLower
        string upperCaseString = originalString.ToUpper();
        string lowerCaseString = originalString.ToLower();
        Console.WriteLine("Uppercase: " + upperCaseString);
        Console.WriteLine("Lowercase: " + lowerCaseString);

        // Concatenation
        string concatString = String.Concat("Hello", ", ", "World", "!");
        Console.WriteLine("Concatenation: " + concatString);

        // IndexOf
        int indexOfComma = originalString.IndexOf(",");
        Console.WriteLine("Index of ',': " + indexOfComma);

        // LastIndexOf
        int lastIndexOfSpace = originalString.LastIndexOf(" ");
        Console.WriteLine("Last Index of space: " + lastIndexOfSpace);

        // Replace
        string replacedString = originalString.Replace("Hello", "Hi");
        Console.WriteLine("Replaced String: " + replacedString);

        // Trim
        string stringWithWhitespace = "   This is a string with whitespace.   ";
        string trimmedString = stringWithWhitespace.Trim();
        Console.WriteLine("Trimmed String: " + trimmedString);

        // Split
        string sentence = "This is a sample sentence.";
        string[] words = sentence.Split(' ');

        Console.WriteLine("Words in the sentence:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // StartsWith and EndsWith
        bool startsWithHello = originalString.StartsWith("Hello");
        bool endsWithExclamation = originalString.EndsWith("!");
        Console.WriteLine("Starts with 'Hello': " + startsWithHello);
        Console.WriteLine("Ends with '!': " + endsWithExclamation);

        // Contains
        bool containsWorld = originalString.Contains("World");
        Console.WriteLine("Contains 'World': " + containsWorld);

        // Empty and IsNullOrEmpty
        string emptyString = "";
        string nullString = null;

        Console.WriteLine("IsNullOrEmpty(emptyString): " + string.IsNullOrEmpty(emptyString));
        Console.WriteLine("IsNullOrEmpty(nullString): " + string.IsNullOrEmpty(nullString));
        Console.WriteLine("IsNullOrEmpty(originalString): " + string.IsNullOrEmpty(originalString));

        // Join
        string[] fruits = { "Apple", "Banana", "Orange", "Mango" };
        string joinedFruits = string.Join(", ", fruits);
        Console.WriteLine("Joined Fruits: " + joinedFruits);

        // Format
        int age = 30;
        string name = "John";
        string formattedString = string.Format("My name is {0} and I am {1} years old.", name, age,age);

        string formattedString02 = $"My name is {name} and I am {age} years old.";

        Console.WriteLine("Formatted String: " + formattedString);

        //string builder

        StringBuilder sb = new StringBuilder();

        // Append strings to the StringBuilder
        sb.Append("Hello, ");
        sb.Append("how ");
        sb.Append("are ");
        sb.Append("you?");

        // Get the final string from the StringBuilder
        string result = sb.ToString();

        // Print the result
        Console.WriteLine(result);
    }
}
