using System;
using System.Collections.Generic;
using System.Text;

namespace JobInterviewPrepare.LeetCode
{


    // Time complexity : O(n^2)
    public class ThreeSum
    {

        
        // Run a nested loop with two loops, outer loop from 0 to n-2 and the inner loop from i+1 to n-1.
        // Check if the sum of ith and jth element multiplied with -1 is present in the hashmap or not.
        // if the element is present in the hashmap, print the triplet else isnert the j'th element in the hashmap. 
        public static void infTriplets(int[] arr, int n)
        {
            int count = 0;
            bool isFound = false;
            for (int i = 0; i < n - 1; i++)
            {
                HashSet<int> set = new HashSet<int>();// Create a hashmap to store a key value pair.
                for (int j = i + 1; j < n; j++)
                {
                    int x = -(arr[i] + arr[j]);
                    if(set.Contains(x))
                    {
                        Console.WriteLine("{0}, {1}, {2}\n", x, arr[i], arr[j]);
                        Console.WriteLine("Total Count : " + count);
                        isFound = true;
                    }
                    else
                    {
                        set.Add(arr[j]);
                    }
                    count++;
                }
            }
            if(!isFound)
            {
                Console.WriteLine("Failed to Found!");
            }
        }
        // TODO : Upgrade this function tomorrow!
        //https://www.geeksforgeeks.org/find-a-triplet-that-sum-to-a-given-value/


    }
}
