using System;

namespace CSharpBestPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // HJow is exception handling implemented..
        //try catch finnally throw!



        // What are dynamic type variables? 
        //You can store any type of value in the dynamic data type variable. Type checking for these types of variables takes place at run-time.  
    }
}



/*

Managed code is a code created by the .NET compiler. It does not depend on the architecture of the target machine because it is executed by the CLR (Common Language Runtime), and not by the operating system itself.
CLR and managed code offers developers few benefits, like garbage collection, type checking and exceptions handling.
On the other hand, unmanaged code is directly compiled to native machine code and depends on the architecture of the target machine.
It is executed directly by the operating system. In the unmanaged code,
the developer has to make sure he is dealing with memory usage and allocation (especially because of memory leaks),
type safety and exceptions manually.
In .NET, Visual Basic and C# compiler creates managed code. To get unmanaged code, the application has to be written in C or C++.
*/


//While constants and read-only variable share many similarities, there are some important differences:

//    Constants are evaluated at compile time, while the read-only variables are evaluated at run time.
//    Constants support only value-type variables (the only exception being strings), while read - only variables can hold reference-type variables.
//    Constants should be used when the value is not changing during run time, and read-only variables are used mostly when their actual value is unknown before run time.
//    Read-only variables can only be initialised at the time of declaration or in a constructor.

