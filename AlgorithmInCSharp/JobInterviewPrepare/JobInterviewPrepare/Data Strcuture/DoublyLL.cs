
using JobInterviewPrepare;
namespace JobInterviewPrepare.Data_Strcuture
{
    public class DoublyLL
    {
        Node head;
        Node tail;
        int value;
        public DoublyLL()
        {
            value = 0;
            head = null;
            tail = null;
        }
        public DoublyLL(int value)
        {
            this.value = value;
            head = null;
            tail = null;
        }
        public void InsertFront(DoublyLL doublyLL, int value)
        {
            Node newNode = new Node(value);
            newNode.next = doublyLL.head;
            //newNode.prev = null;
            if(doublyLL.head != null)
            {
                //doublyLL.head.prev = newNode;
            }
            doublyLL.head = newNode;
        }
        // if the linked list is empty, then we simply add the new node as the Head of the LL.
        
        public void InsertLast(DoublyLL doublyLL, int value)
        {
        }
        public void GetLastNode(DoublyLL dll)
        {
        }
        // insert a new node after a give node.
        public void InsertAfterNode(Node _node, int value)
        {

            return;
        }

    }
}

// Internal vs Public method. 
// Algorithm  comparison.... where I can test it?  
// Managed code is a code that is executed by CLR(Command Language Runtime) 
// Net is considered as managed beceause of the net framework which internally uses the garbage collector to clear up the unused memory . (Important@!!!!!)


// Insert a node in a DDL .
// 1. isnert a new node before head.
// 2. Insert a new node at the end of the list
// 3. Isnert a new node in the middle of the list.
 