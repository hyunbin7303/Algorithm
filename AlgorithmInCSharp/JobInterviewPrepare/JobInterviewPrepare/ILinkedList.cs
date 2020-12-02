using System;
using System.Collections.Generic;
using System.Text;

namespace JobInterviewPrepare
{
    internal class Node
    {
        internal int data;
        internal Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }



    public interface IAlgorithm
    {



        // A LL is a linear data strcture which consists of a group of nodes in a sequence. 
        int SinglyLinkedList();
        int DoublyLinkedList();
        int CircularLinkedList();

        //Search a sorted array by repeatedly dividing the search interval in half. 
        int BinarySearch(int [] arr, int l, int r, int target);
    }
}
