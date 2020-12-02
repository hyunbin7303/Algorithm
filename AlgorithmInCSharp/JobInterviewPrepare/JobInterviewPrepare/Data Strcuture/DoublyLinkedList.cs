using System;
using System.Collections.Generic;
using System.Text;

namespace JobInterviewPrepare
{
    public class DoubleNode
    {
        public int Data { get; set; }
        public DoubleNode prev;
        public DoubleNode next;
        public DoubleNode()
        {
            Data = 0;
            prev = next = null;
        }
        public DoubleNode(int data)
        {
            Data = data;
        }
    }
    public class DoublyLinkedList
    {
        public DoubleNode head = null;
        public void InsertFront(DoublyLinkedList dll, int value)
        {
            DoubleNode newNode = new DoubleNode(value);
            newNode.prev = null;
        }
        public void InsertLast(DoublyLinkedList dll, int value)
        {
        }
        public void Traverse()
        {
            DoubleNode temp = new DoubleNode();
            temp = this.head;
            if(temp != null)
            {
                while(temp != null)
                {
                    Console.WriteLine(temp.Data + " " );
                    temp = temp.next;
                }
            }
            else
            {
                Console.WriteLine("\n The list is empty.");
            }
        }

    }
}
