using Algorithms.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class SwapNodesInPairs
    {
        public static ListNode Run(ListNode list)
        {
            return Swap(list.CopyRec());
        }

        private static ListNode Swap(ListNode list)
        {
            if (list?.next == null) return list;

            var head = list;
            var newHead = head.next;

            head.next = Swap(head.next?.next);
            newHead.next = head;

            return newHead;
        }
    }
}
