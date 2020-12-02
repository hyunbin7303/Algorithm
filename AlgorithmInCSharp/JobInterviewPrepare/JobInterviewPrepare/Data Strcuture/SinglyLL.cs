using System;

// SLL contain nodes which have a data part and an address part.
// next which points to the next node in the sequence of nodes.
// the next pointer of the last node will point to null. 
namespace JobInterviewPrepare
{
    public class SinglyLL
    {
        int value;

        SinglyLL next;
        public SinglyLL(int nodeValue)
        {
            value = nodeValue;
            next = null;
        }
            // only insert data at afront of the LL.
        public SinglyLL Insert(int newValue)
        {
            SinglyLL newnode = new SinglyLL(newValue);
            if(this.next == null)
            {
                this.next = newnode;
            }
            else{
                SinglyLL temp = this.next;  
                newnode.next = temp;
                this.next = temp;
            }
            return newnode;
        }


        // only deleting ...?
        // Please test this method!
        public int Delete()
        {
            if(next == null)
            {
                return 0;
            }
            SinglyLL node = this.next;
            this.next = this.next.next;
            node =null;
            return 1;
        }



        public void Traverse(SinglyLL Node)
        {
            if(Node == null)
            {
                Node = this;
            }
            while(Node != null)
            {
                System.Console.WriteLine(Node.value);
                Node = Node.next;
            }
        }

    }
}



