using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpGrammar
{

    public class Small{}
    public class Big: Small
    {
    }
    public class Bigger : Big { }
    public delegate Small convarianceDelegate(Big mc);
    public class Covariance_Contravariance
    {
        // Covariance and Contravariance allow us to be flexible when dealing with class hierarchy.

        // Covariance enables u to pass a derived type where a base type is expected.
        public static Big MethodTesting(Big bg)
        {
            Console.WriteLine("Method 1 ");
            return new Big();
        }
        public static Small MethodSmallTesting(Big bg)
        {
            Console.WriteLine("Method 2 ");
            return new Small();
        }
        public void MainMethod()
        {
            convarianceDelegate delegateTest = MethodTesting;
            Small sm1 = delegateTest(new Big());

            delegateTest = MethodSmallTesting;
            Small sm2 = delegateTest(new Big());

        }
       
    
    }
}
