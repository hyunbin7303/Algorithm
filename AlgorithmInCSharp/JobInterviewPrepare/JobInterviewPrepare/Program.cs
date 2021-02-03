using JobInterviewPrepare.Data_Strcuture;
using JobInterviewPrepare.LeetCode;
using JobInterviewPrepare.Searching;
using JobInterviewPrepare.Sorting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace JobInterviewPrepare
{
    class Program
    {
        static void TestingSinglyLL()
        {
            SinglyLinkedList sll = new SinglyLinkedList();
            SingleNode sn = new SingleNode(10);
            sll.AddNode(sn);
            SingleNode sn1 = new SingleNode(20);
            sll.AddNode(sn1);
            SingleNode sn2 = new SingleNode(30);
            sll.AddNode(sn2);
            SingleNode sn3 = new SingleNode(40);
            sll.AddNode(sn3);
            SingleNode sn4 = new SingleNode(50);
            sll.AddNode(sn4);

            sll.Traverse(null);
            Console.WriteLine("Reversing");
            sll.ReversingLL();
            sll.Traverse(null);
        }
        static void TestingDoublyLL(int size)
        {
            DoublyLinkedList dll = new DoublyLinkedList();
            var dn = new DoubleNode(10);
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
            BSTNode FindThis = null;
            int findthisNumber = 0;
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
                if(i==5){
                    root = bst.Insert(root, input[i]);
                    FindThis = root;
                    findthisNumber = input[i];
                    continue;
                }
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


            stopwatch = Stopwatch.StartNew();
            var check = bst.Find(FindThis, findthisNumber);
            stopwatch.Stop();
            Console.WriteLine("Took {0} seconds for Traversing.", (double)stopwatch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();



        }
        //create binary search.
        static int BinarySearch_01(int[] arr, int front, int end, int goal)
        {
            if (arr == null)
                return -1;

            // get the mid value.
            int mid = (front + end) / 2;
            if(arr[mid] == goal)
            {
                return mid;
            }
            else if (front >= end)
            {
                return -1;
            }
            // compare mid value with goal value.
            //1. if goal is lower than mid
            if (goal < arr[mid])
            {
                // call BinarySearch_01 again for find from the first .... (something)
                return BinarySearch_01(arr, front, mid-1, goal);           
            }
            else //2. if goal is higher than mid 
            {
                // Call BinarySarch_901 again for find from the mid+1 to end. 
                return BinarySearch_01(arr, mid + 1, end, goal);
            }

        }
        static bool BinarySearch_01_Test()
        {
            int[] arr = { 10, 20, 30, 40, 50, 60, 70, 85, 90, 100, 110 };
            int value = BinarySearch_01(arr, 0, arr.Length, 10);
            return true;
        }
        static void TestFibonnaci()
        {
            int result = Recursive.FibonacciSequence(5);
            Console.WriteLine($"Fibonnaci value : {result}");
        }
        static void TestFindTriplets()
        {
            int[] arr = { 0, -1, 2, -3, 1,4,5 };
            int n = arr.Length;
            ThreeSum.infTriplets(arr, n);
        }
        static bool DoublyLLTesting()
        {
            //DoublyLinkedList
            DoubleNode dn = new DoubleNode(10);
            DoublyLL dll = new DoublyLL();
            return true;
        }

        static void QuickSortTesting()
        {
            int[] arr = { 10, 7, 8, 9, 1, 5 };
            int n = arr.Length;
            QuickSort quickSort = new QuickSort();
            quickSort.quickSort(arr, 0, n - 1);

        }

        // Integration Testing. 
        static void Main(string[] args)
        {
            //TestingSinglyLL();
            //BinarySearch_01_Test();
            //BSTAlgorithm(10);
            //DoublyLLTesting();
            //TestFibonnaci();
            //TestFindTriplets();
            QuickSortTesting();


        }
    }
}
