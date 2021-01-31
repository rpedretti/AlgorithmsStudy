using Algorithms.Extensions;

namespace Algorithms
{
    public class RemoveNthNode
    {
        public static ListNode Run(ListNode head, int n)
        {
            //do not change original list
            var copy = head.CopyIter();

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
    }
}
