using System;
using System.Collections.Generic;
using System.Text;

namespace JobInterviewPrepare
{
    public class Algorithm : IAlgorithm
    {
        // l is the first index
        // r is the last index.
        public int BinarySearch(int[] arr, int l, int r, int target) // Recursive implementation.
        {
            if ( r>= l)
            {
                int mid = l + (r - 1) / 2;
                if(arr[mid] == target)
                {
                    return mid;
                }
                if(arr[mid] > target)
                {
                    return BinarySearch(arr, l, mid - 1, target);
                }
                return BinarySearch(arr, mid+1, r, target);
            }
            return -1;
        }
        public static int BinarySearchRecursive(int [] arr, int min, int max, int target)
        {
            if (min > max)
            {
                return -1;
            }
            else
            {
                //int mid = (min + max) / 2;
                //if()
                return 0;
            }
        }
        public int BinarySearchTesting(int[] arr, int l, int r, int target)
        {
            int mid = (l + r) / 2;
            if(arr[mid] == target)
            {
                return mid;
            }
            else if( l >= r)
            {
                return -1;
            }
            else if(target < arr[mid])
            {
                return BinarySearchTesting(arr, l, mid, target);
            }
            else
            {
                return BinarySearchTesting(arr, mid, r, target);
            }
           
        }

        //Circular Linked List : Circular linked list is a linked list where all nodes are connected to form a circle. There is no NULL at the end. A circular linked list can be a singly circular linked list or doubly circular linked list. 
        //Eg. 1->2->3->1 [The next pointer of last node is pointing to the first]
        public int CircularLinkedList()
        {
            throw new NotImplementedException();
        }
        // Better version of singly Linked List. --> since Singly LL cannot be removed unless we know the point of its predecessor, 
        // Here, here are two references associated with each node, One of the reference points to the next node and one to the previous node. 
        //Eg. NULL<-1<->2<->3->NULL
        public int DoublyLinkedList()
        {
            throw new NotImplementedException();
        }
        //In this type of linked list, every node stores address or reference of next node in list and the last node has next address or reference as NULL.
        //For example 1->2->3->4->NULL
        public int SinglyLinkedList()
        {
            throw new NotImplementedException();
        }




    }
}


// Binary search works by keeping track of the midpoint and the minimum and maximum positions where the item might be.
