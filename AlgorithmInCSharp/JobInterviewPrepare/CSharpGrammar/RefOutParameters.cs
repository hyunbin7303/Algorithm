using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGrammar
{
    public class RefOutParameters
    {

        // Out keyword is used for passing the arguments to methods as a reference type. 
        /* ref and out are passed as reference.
         * Out : only for output not for input.
         * 
         * ref variable must be initialization before passing it as parameter.
         * Out variable don't require initialization even if out variable is initialized before passing it as parameter then that initialization value cannot ....
         */
        public void OutParameterTest()
        {
            //int[] numberArr = { 20, 30 };
            //ref int second = ref test(async, out int sum);
            int x, y = 0;
            Addition(out x, out y);
            Console.WriteLine($"x value : {x}, y value : {y}");

        }

        // ref returns

        // ref locals

        // Inline out variable declaration. (Declaring out variable directly while passing it as parameter



        // Method in which out parameter is passed and this method returns the value of the passed parameter.
        public static void Addition(out int value)
        {
            value = 10;
            value += value;
        }

        public static void Addition(out int value, out int value2)
        {
            value = 30;
            value2 = 40;
        }
       

    }
}
