using System;
using System.Collections.Generic;
using System.Text;

namespace JobInterviewPrepare.Data_Strcuture
{
    public class Node
    {
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
}
