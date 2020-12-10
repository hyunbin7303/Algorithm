using System;
// SLL contain nodes which have a data part and an address part.
// next which points to the next node in the sequence of nodes.
// the next pointer of the last node will point to null. 
namespace JobInterviewPrepare
{
    public class SinglyLinkedList
    {
        private int data;
        private SingleNode head;
        public SinglyLinkedList()
        {
        }
        // insert into front
        // something wrong in here?
        public SingleNode InsertNext(int value)
        {
            SingleNode node = new SingleNode(value);
            if (this.head == null)
            {
                node.next = null;
                this.head = node;
            }
            else
            {
                SingleNode temp = this.head;
                node.next = temp;
                this.head = node;
            }
            return node;
        }

        public void AddNode(SingleNode sn)
        {
            if (sn == null) return;
            if (head == null)
            {
                head = sn;
            }
            else
            {
                SingleNode temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = sn;
            }
        }
        public void Traverse(SingleNode node)
        {
            if (node == null) {
                node = head;
            }
            Console.WriteLine("\nTraversing in forward direction. \n");
            while (node != null)
            {
                Console.WriteLine(node.data);
                node = node.next;
            }
        }
        // Reversing Linked LIst.
        // 1. Initialize thee pointers prev as null. curr as head and next as null?...
        // 2. Iterate through the linked list.
        // Change head.
        public void ReversingLL()
        {
            SingleNode prev = null; // This will be the result value.
            SingleNode next = null;
            SingleNode curr = head;

            while(curr != null)
            {
                next = curr.next;
                curr.next = prev;
                prev = curr;
                curr = next;
            }
            head = prev;
        }

    }
}
