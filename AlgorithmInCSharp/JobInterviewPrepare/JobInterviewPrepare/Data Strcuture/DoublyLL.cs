//https://dzone.com/articles/linked-list-implementation-in-c must study!
// https://www.c-sharpcorner.com/article/doubly-linked-list-and-circular-linked-list-in-c-sharp/
// http://www.softwareandfinance.com/CSharp/Doubly_Linked_List.html
// https://leetcode.com/problems/add-two-numbers/solution/
// https://pythonprogramming.net/sp500-company-list-python-programming-for-finance/#google_vignette
namespace AlgorithmLib 
{
    // duplicated.
    public class Node {
        public int data;
        public Node prev;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            prev = null;
            next = null;
        }
    }
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
            newNode.prev = null;
            if(doublyLL.head != null)
            {
                doublyLL.head.prev = newNode;
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
        }
    }
}
// Seems important 
// implementing Stack and Queue in Linked List? 
// Internal vs Public method. 
// Algorithm  comparison.... where I can test it?  
// Managed code is a code that is executed by CLR(Command Language Runtime) 
//Net is considered as managed beceause of the net framework which internally uses the garbage collector to clear up the unused memory . (Important@!!!!!)
// Interface?
// Interface is a class with no implementation...........//
