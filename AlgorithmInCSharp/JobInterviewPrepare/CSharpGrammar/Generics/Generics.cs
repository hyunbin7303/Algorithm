using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGrammar
{
//Generic.
//Type as a value.
//it allows you to define the type-safe data strctures.
//This out-turn in a remarkable performance boost and high-tgrade code,
//because it helps to reuse data processing alogorithm
//...

//Use generic types to maximize code reuse, type safety, and performance. 
//Optimization + Maintainbility.

//Generics decouples data type from logic and thaus increases resuability.
    public class Generics
    {
        class Box<T>
        {
            public T Value;
            public Box(T value)
            {
                Value = value;
            }
        }

        public void DoTest0<T>(T i)
        {
            Console.WriteLine(i);
        }
        public void DoTestClassType<T>(T i) where T : class
        {
            Console.WriteLine(i);
        }

        public void Do<T>(T i) where T : class, new()
        {

        }
        public void Do2<T>(T i) where T : Box, new()
        {

        }

       
        public void GenericTest<T>(T i)
        {
            DoTest0(30);
            DoTestClassType("haha");

            Do(30);
            Do<string>("ahah");

        }
    }
}
