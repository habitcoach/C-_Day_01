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
            int num = Int32.Parse(result);
            Console.Write("something");
        }
    }
}
