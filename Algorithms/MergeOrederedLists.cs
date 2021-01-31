using Algorithms.Extensions;

namespace Algorithms
{
    public static class MergeOrederedLists
    {
        public static ListNode Run(ListNode l1, ListNode l2)
        {
            var dummy = new ListNode(-999);

            var head = dummy;

            var headL1 = l1.CopyIter();
            var headL2 = l2.CopyIter();

            while (headL1 != null && headL2 != null)
            {
                if (headL1.val < headL2.val)
                {
                    dummy.next = headL1;
                    headL1 = headL1.next;
                }
                else
                {
                    dummy.next = headL2;
                    headL2 = headL2.next;
                }

                dummy = dummy.next;
            }

            dummy.next = headL1 ?? headL2;

            return head.next;
        }
    }
}
