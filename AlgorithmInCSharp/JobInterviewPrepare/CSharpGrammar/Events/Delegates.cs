using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGrammar
{
    class Delegates
    {
        // function pointers in C++, but type safe.
        //can be used to write much more generic type-safe functions.

        // Using the delegate allows you do have a function called whenever the event occurs. 
        // Linq uses the Func<T> and Action<T> delegates all over the place as parameters.

        public delegate bool EligibleA(A a);
        public static void ChangeName(List<A> As)
        {
            foreach(A a in As)
            {
                Console.WriteLine("{0}", a.Name);
            }
        }



    }
}
