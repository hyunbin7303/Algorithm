using System;
using System.Collections.Generic;
using System.Text;

namespace JobInterviewPrepare
{
    public class Algorithm : ILinkedList
    {
        

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
