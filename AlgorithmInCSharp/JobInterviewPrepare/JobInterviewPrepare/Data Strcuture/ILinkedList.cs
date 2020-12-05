
namespace JobInterviewPrepare
{
    internal class SingleNode
    {
        internal int data;
        internal SingleNode next;
        public SingleNode(int d)
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
