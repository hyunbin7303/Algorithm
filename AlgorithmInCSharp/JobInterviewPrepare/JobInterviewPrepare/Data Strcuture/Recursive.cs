using System;
using System.Collections.Generic;
using System.Text;

namespace JobInterviewPrepare
{

    // Mainly focus on Recusive Algorithm .
    // Recusion is a process in which a funtion will call itself within it's own code. 
    public class Recursive
    {
        public static int FibonacciSequence(int num)
        {
            if(num <=2)
            {
                return num;
            }
            return FibonacciSequence(num - 1) + FibonacciSequence(num - 2);
        }


        public static int IterationTestin(int [] arr)
        {
            return 0;
        }

        // Recusion by means of stacks. 
        //public static int CountDivisions(double number)
        //{
        //    int count = 0;
        //    if(number >0 && number%2 == 0)
        //    {
        //        count++;

        //    }
        //}
            
    }
}
    