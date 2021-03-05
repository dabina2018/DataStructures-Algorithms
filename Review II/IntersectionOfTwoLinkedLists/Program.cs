using System;
using System.Collections;
using System.Collections.Generic;

namespace IntersectionOfTwoLinkedLists
{
    class Program
    {
        //Input: intersectVal = 8, listA = [4,1,8,4,5], listB = [5,6,1,8,4,5], skipA = 2, skipB = 3
        //Output: Reference of the node with value = 8
        //Input Explanation: The intersected node's value is 8 (note that this must not be 0 if the two lists intersect). 
        //      From the head of A, it reads as [4,1,8,4,5]. 
        //      From the head of B, it reads as [5,6,1,8,4,5]. 
        //There are 2 nodes before the intersected node in A; There are 3 nodes before the intersected node in B.
        static void Main()
        {
            ListNode listNodeA = new ListNode(1);
            listNodeA.next = new ListNode(9);
            listNodeA.next.next = new ListNode(1);
            listNodeA.next.next.next = new ListNode(2);
            listNodeA.next.next.next.next = new ListNode(4);

            ListNode listNodeB = new ListNode(3);
            listNodeB.next = new ListNode(2);
            listNodeB.next.next = new ListNode(4);
            //listNodeB.next.next.next = new ListNode(8);
            //listNodeB.next.next.next.next = new ListNode(4);
            //listNodeB.next.next.next.next.next = new ListNode(5);
            GetIntersectionNode(listNodeA, listNodeB);
        }
       
        public static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            HashSet<ListNode> listA = new HashSet<ListNode>();
                
            ListNode current = headA;
            if (headA == null || headB == null)
            {
                return null;
            }
            if (headA == headB)
            {
                return headA;
            }
            while (current != null)
            {
                listA.Add(current);
                current = current.next;
            }
            current = headB;
            while (current != null)
            {
                if (listA.Contains(current)) //check for matching node
                {
                        return current; //check hashset at found key for matching node
                }
                current = current.next;
            }
            return null;
        }
        
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        //traverse listA and add each node to a hashtable (val/next)
        // traverse list B and compare each node to hashtable entries
        //          return the match

    }
}
