//http://www.softwareandfinance.com/CSharp/Singly_Linked_List.html Test it later!

using System;
using System.Collections.Generic;
using System.Text;

namespace JobInterviewPrepare
{
    public class SinglyLinkedList
    {
        private int data;
        private SinglyLinkedList next;
        public SinglyLinkedList()
        {
            data = 0;
            next = null;
        }
        public SinglyLinkedList(int value)
        {
            data = value;
            next = null;
        }
        public SinglyLinkedList InsertNext(int value)
        {
            SinglyLinkedList node = new SinglyLinkedList(value);
            if (this.next == null)
            {
                node.next = null;
                this.next = node;
            }
            else
            {
                SinglyLinkedList temp = this.next;
                node.next = temp;
                this.next = node;
            }
            return node;
        }
        public int DeleteNext()
        {
            if (next == null)
            {
                return 0;
            }
            SinglyLinkedList node = this.next;
            this.next = this.next.next;
            node = null;
            return 1;
        }
        public void Traverse(SinglyLinkedList node)
        {
            if (node == null)
            {
                node = this;
            }
            Console.WriteLine("\nTraversing in forward direction. \n");
            while (node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }
    }
}
