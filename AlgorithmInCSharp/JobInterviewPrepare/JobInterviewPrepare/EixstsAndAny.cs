﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace JobInterviewPrepare
{
    public class EixstsAndAny
    {
        private static void ContainsExistsAny()
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("********* ContainsExistsAny ***********");
            Console.WriteLine("***************************************");

            List<int> list = new List<int>(6000000);
            Random random = new Random();
            for (int i = 0; i < 6000000; i++)
            {
                list.Add(random.Next(6000000));
            }
            int[] arr = list.ToArray();

            find(list, arr);
        }
        private static void ContainsExistsAnyShort()
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("***** ContainsExistsAnyShortRange *****");
            Console.WriteLine("***************************************");

            List<int> list = new List<int>(2000);
            Random random = new Random();
            for (int i = 0; i < 2000; i++)
            {
                list.Add(random.Next(6000000));
            }
            int[] arr = list.ToArray();

            find(list, arr);
        }
        private static void find(List<int> list, int[] arr)
        {
            Random random = new Random();
            int[] find = new int[10000];
            for (int i = 0; i < 10000; i++)
            {
                find[i] = random.Next(6000000);
            }

            Stopwatch watch = Stopwatch.StartNew();
            for (int rpt = 0; rpt < 10000; rpt++)
            {
                list.Contains(find[rpt]);
            }
            watch.Stop();
            Console.WriteLine("List/Contains: {0:N0}ms", watch.ElapsedMilliseconds);

            watch = Stopwatch.StartNew();
            for (int rpt = 0; rpt < 10000; rpt++)
            {
                list.Exists(a => a == find[rpt]);
            }
            watch.Stop();
            Console.WriteLine("List/Exists: {0:N0}ms", watch.ElapsedMilliseconds);

            watch = Stopwatch.StartNew();
            for (int rpt = 0; rpt < 10000; rpt++)
            {
                list.Any(a => a == find[rpt]);
            }
            watch.Stop();
            Console.WriteLine("List/Any: {0:N0}ms", watch.ElapsedMilliseconds);

            watch = Stopwatch.StartNew();
            for (int rpt = 0; rpt < 10000; rpt++)
            {
                arr.Contains(find[rpt]);
            }
            watch.Stop();
            Console.WriteLine("Array/Contains: {0:N0}ms", watch.ElapsedMilliseconds);

            Console.WriteLine("Arrays do not have Exists");

            watch = Stopwatch.StartNew();
            for (int rpt = 0; rpt < 10000; rpt++)
            {
                arr.Any(a => a == find[rpt]);
            }
            watch.Stop();
            Console.WriteLine("Array/Any: {0:N0}ms", watch.ElapsedMilliseconds);
        }
    }
}
