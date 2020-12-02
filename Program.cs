using System;
using AlgorithmLib;
using System.Reflection;
namespace Algorithm
{
    class Program
    {



            // singly linked list only using One class....
        static void SinglyLL_Testing()
        {
            System.Console.WriteLine(MethodBase.GetCurrentMethod().Name);
            SinglyLL node1 = new SinglyLL(1);
            SinglyLL node2 =  node1.Insert(2);
            SinglyLL node3 =  node2.Insert(3);
            SinglyLL node4 =  node3.Insert(4);
            SinglyLL node5 =  node4.Insert(5);
            node1.Traverse(node1);
        }

        // Signly linked list by using Node class.
        static void SinglyLL_TestingWithNode()
        {
            System.Console.WriteLine(MethodBase.GetCurrentMethod().Name);
            SinglyLLWithNode
        }
        

        static void DoublyLL_Testing()
        {

        }

        static void Main(string[] args)
        {
            SinglyLL_Testing();
            System.Console.WriteLine( "END the application.");
        }
    }
}
