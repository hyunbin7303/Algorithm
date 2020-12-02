
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
    public interface ILinkedList
    {
        // A LL is a linear data strcture which consists of a group of nodes in a sequence. 
        int SinglyLinkedList();
        int DoublyLinkedList();
        int CircularLinkedList();
    }
}
