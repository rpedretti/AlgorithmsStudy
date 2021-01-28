using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class RemoveNthNode
    {
        public static ListNode Run(ListNode head, int n)
        {
            //do not change original list
            var copy = CopyIter(head);

            var dummy = new ListNode(0)
            {
                next = copy 
            };

            // keep pointers to compare
            var first = dummy;
            var second = dummy;

            // advance the first pointer by n positions
            for (var i = 1; i <= n; i++)
            {
                first = first.next;
            }

            // keep advancing until end of list
            while (first.next != null)
            {
                first = first.next;
                second = second.next;
            }

            // by this point second will be n+1 positions behind first
            // so we skip the next
            second.next = second.next.next;

            return dummy.next;
        }

        private static ListNode CopyIter(ListNode toCopy)
        {
            ListNode dummy = new ListNode(0, toCopy);
            ListNode res = dummy;

            while (dummy != null)
            {
                if(dummy.next != null)
                {
                    dummy.next = new ListNode(dummy.next.val, dummy.next.next);
                }
                
                dummy = dummy.next;
            }

            return res.next;
        }

        //private static ListNode CopyRec(ListNode toCopy)
        //{
        //    return toCopy != null 
        //        ? new ListNode(toCopy.val, CopyRec(toCopy.next))
        //        : null;
        //}
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
