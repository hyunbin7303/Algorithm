using System;
using System.Text;

namespace CSharpGrammar
{
    public class StringBuilderUsage
    {
        // string objects are immutable but stringbuilder is the mutable string type.
        // 
        

        public static void Concating()
        {
            string st = "Checking";
            System.Text.StringBuilder checking = new StringBuilder("Testing Kevin String builder");
            //checking 

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
    }
}
