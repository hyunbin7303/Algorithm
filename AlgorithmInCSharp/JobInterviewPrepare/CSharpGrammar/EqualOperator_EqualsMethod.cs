using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace CSharpGrammar
{
    public class Box
    {
        public Box(int h, int l, int w)
        {
            this.Height = h;
            this.Length = l;
            this.Width = w;
        }
        public int Height { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public override String ToString()
        {
            return String.Format("({0}, {1}, {2})", Height, Length, Width);
        }
    }

    class BoxEqualityComparer : IEqualityComparer<Box>
    {
        public bool Equals([AllowNull] Box x, [AllowNull] Box y)
        {
            throw new NotImplementedException();
        }

        public int GetHashCode([DisallowNull] Box obj)
        {
            throw new NotImplementedException();
        }
    }


    public class A
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
    }

    public interface IEqualityComparer<in T>
    {
        bool Equals([AllowNull] T x, [AllowNull] T y);
        int GetHashCode([DisallowNull] T obj);
    }

    public sealed class AEqualityComparer : IEqualityComparer<A>
    {
        public bool Equals([AllowNull] A x, [AllowNull] A y)
        {
            throw new NotImplementedException();
        }
        public int GetHashCode([DisallowNull] A obj)
        {
            throw new NotImplementedException();
        }
    }



    public class EqualOperator_EqualsMethod
    {
        public int Number { get; set; }
        public string Name { get; set; }

        public static void Test_EqualOperator()
        {
            string check = "kevin";
            string check2 = "kevin";
            if(check == check2)
                Console.WriteLine("Value is same");
            if(check.Equals(check2))
                Console.WriteLine("value is same2");

            char[] char_kevin = { 'k', 'e', 'v', 'i', 'n' };
            string convertString = new string(char_kevin);
            if (check == convertString)
                Console.WriteLine("value is same3");
            if (check.Equals(convertString))
                Console.WriteLine("value is same4");
        }
        public static void Test_checking()
        {
            object check = "kevin";
            string check2 = "kevin";
            if (check == check2)
                Console.WriteLine("Value is same");
            if (check.Equals(check2))
                Console.WriteLine("value is same2");

            char[] char_kevin = { 'k', 'e', 'v', 'i', 'n' };
            object convert = new string(char_kevin);
            if (check == convert)
                Console.WriteLine("Value is same3");
            if (check.Equals(convert))
                Console.WriteLine("value is same4");
        }
        public static void Test_ReferenceEquals()
        {
            var num = new A{ Id =1, Name="Kevin"};
            var num2 = new A{ Id =1, Name="Kevin"};
            Console.WriteLine("Reference Equals : {0}", ReferenceEquals(num, num2));

            // Let's assign num2 to num
            num2 = num;
            Console.WriteLine("Reference Equals : {0}", ReferenceEquals(num, num2));

        }
    }
}
