using System.Collections.Generic;

namespace Algorithms.Extensions
{
    public static class ListNodeExtensions
    {
        public static ListNode CopyIter(this ListNode toCopy)
        {
            ListNode dummy = new ListNode(0, toCopy);
            ListNode res = dummy;

            while (dummy != null)
            {
                if (dummy.next != null)
                {
                    dummy.next = new ListNode(dummy.next.val, dummy.next.next);
                }

                dummy = dummy.next;
            }

            return res.next;
        }

        public static ListNode CopyRec(this ListNode toCopy)
        {
            return toCopy != null
                ? new ListNode(toCopy.val, CopyRec(toCopy.next))
                : null;
        }

        public static IEnumerable<int> Values(this ListNode node)
        {
            var values = new List<int>();
            var dummy = new ListNode(0, node);

            while(dummy.next != null)
            {
                values.Add(dummy.next.val);
                dummy = dummy.next;
            }

            return values;
        }
    }
}
