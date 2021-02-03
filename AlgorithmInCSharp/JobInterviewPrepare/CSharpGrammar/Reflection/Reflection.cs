using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CSharpGrammar
{
    public class Reflection
    {
        // The process of obtaining information about assemblies and the types defined within them,
        // and creating, invoking, and accessing type instances at runtime.

        // Useful for these reasons:
        // When you have to access attributes in your program's metadata.
        // Examining and instatiating types in an assembly.
        // For building new types at runtime. Use classes in system.Reflection.Emit.

        //So reflection is very important for get the metadata information from assembly.
        public void Reflection_Test()
        {
            Assembly assemblyInfo = typeof(System.Int32).Assembly;
            Console.WriteLine(assemblyInfo);
        }

    }
}
