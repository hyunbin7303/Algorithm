using JobInterviewPrepare.Searching;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace JobInterviewPrepare
{
    class Program
    {
        static void TestingCircularSinglyLL()
        {
        }
        static void TestingSinglyLL()
        {
        }
        static void TestingDoublyLL(int size)
        {
            DoublyLinkedList dll = new DoublyLinkedList();
            for (int i = 0; i < size; i++)
            {

            }
            var dn = new DoubleNode(10);
            dn.prev = null;
            dn.next = null;
            dll.head = dn;

            var dn2 = new DoubleNode(20);
            dn2.prev = dn;
            dn.next = dn2;

            var dn3 = new DoubleNode(30);
            dn3.prev = dn2;
            dn2.next = dn3;

            DoubleNode node = new DoubleNode();
            node = dll.head;
            while (dll != null)
            {
                    
                Console.WriteLine(node.Data +"-");
                node = node.next;
            }
        }
        static void TestingBinarySearch()
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 85, 90, 100, 110 };
            int find = 95;
            BinarySearch bs = new BinarySearch();
            //Search a sorted array by repeatedly dividing the search interval in half. 
            int check = bs.BinarySearching(arr, 0, arr.Length, find);
            if (check != -1)
            {
                Console.WriteLine($"SUCCESS!! Index number : {check}");
            }
        }
        static void BSTAlgorithm(int size)
        {
            BSTNode root = null;
            BST bst = new BST();
            int[] input = new int[size];

            Random ran = new Random();
            Stopwatch stopwatch = new Stopwatch();
            for (int i = 0; i < size; i++)
            {
                input[i] = ran.Next(size);
            }
            stopwatch.Stop();
            Console.WriteLine("1. Took {0} seconds.", (double)stopwatch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine("Filling the tree with {0} node.", size);

            stopwatch = Stopwatch.StartNew(); 
            for (int i = 0; i < size; i++)
            {
                root = bst.Insert(root, input[i]);
            }
            stopwatch.Stop();
            Console.WriteLine("1. Took {0} seconds.", (double)stopwatch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine("Filling the tree with {0} node.", size);

            stopwatch = Stopwatch.StartNew();
            bst.Traverse(root);
            stopwatch.Stop();
            Console.WriteLine("Took {0} seconds for Traversing.", (double)stopwatch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();


        }

        static void Main(string[] args)
        {
            BSTAlgorithm(1000);
        }
        // Need to review 
        // Longest Common Substring question!
        // Suffice to say, it is absolutely essential that you be prepared to solve recursion interview questions in your interview.
        // Making Change. // Given an input amount of change x, write a fucntion to determine the minimum number of coins required to make that amount of change?
    }
}
