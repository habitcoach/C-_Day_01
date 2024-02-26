using System;

using _namespaceRef;


namespace namespacemain
{
    class Program
    {
        static void Main(string[] args)
        {
            Display dObject = new Display();

           var result= dObject.DisplayMethod();

          Console.WriteLine(result);

         
        }
    }
}
