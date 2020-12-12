using System;
using System.Collections.Generic;
using System.Text;

namespace JobInterviewPrepare.Data_Strcuture.LinkedList_Questions
{
    public class DetectCycle
    {

        public void CreateCycle()
        {
            Node cur = head;
            while (cur.next != null)
            {
                cur = cur.next;
            }
            cur.next = head;
        }


        //// Given a linked list, check if the ll has loop or not.

        //public bool DetectCycleInLL()
        //{
        //    Node lag = head;
        //}

    }
    // Solution : Use Hasing.
    // Traverse the list one by one and keep putting the node addresses in a hash table.

    // at any point, if null is reached then return false and if next of current node points to any of the previously stored nodes in Has then return false. 



}
