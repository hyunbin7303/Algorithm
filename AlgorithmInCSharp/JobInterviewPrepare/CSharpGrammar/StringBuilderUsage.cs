using System;
using System.Diagnostics;
using System.Text;

namespace CSharpGrammar
{
    public class StringBuilderUsage
    {
        // string is immutable. If you create string object, you can't modify it and it always create new object of string in memory.
        // stringbuilder is the mutable string type.
        // Stringbuilder perfrorms faster than string when appending multiple string values.
        // Use the Append() method to  add or append string to the stringBuilder Object. 
        // String builder doesn't create a new object in the memory but dynamically expands memory to accommodate the modified string.
        public static void Concating()
        {
            string st = "Checking";
            StringBuilder checking = new StringBuilder("Testing Kevin String builder");
            StringBuilder checking2 = new StringBuilder("Testing Kevin String Builder", 50); // allocates a maximum of 50 spaces sequentially on the memory heap. 
            checking.Append("  YOYOYOYO.");
            checking.AppendLine("Hello World!");
        }
        public static void Testing()
        {
            string check = string.Empty;
            Stopwatch watch = new Stopwatch();
            watch.Start();
            for(int i = 0; i< 30000; i++)
            {
                check += i.ToString();
            }
            watch.Stop();
            Console.WriteLine("Using string to add character : " +  watch.ElapsedMilliseconds);

            StringBuilder sb = new StringBuilder();
            watch.Restart();
            for(int i = 0; i<30000; i++)
            {
                sb.Append(i.ToString());
            }
            watch.Stop();
            Console.WriteLine("Ustring string builder to add character : " + watch.ElapsedMilliseconds);

        }

    }
}
