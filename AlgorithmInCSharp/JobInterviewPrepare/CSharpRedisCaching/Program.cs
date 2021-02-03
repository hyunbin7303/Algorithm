using Microsoft.Extensions.Caching.Memory;
using System;

namespace CSharpRedisCaching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Redis Caching Practice. ");

            var cache = new MemoryCache("demoCache");

        }
    }
}
