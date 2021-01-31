using Algorithms.Extensions;
using System.Linq;

namespace Algorithms
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public static ListNode FromIntArray(int[] values)
        {
            var dummy = new ListNode(0);
            var head = dummy;
            
            foreach (var value in values)
            {
                dummy.next = new ListNode(value);
                dummy = dummy.next;
            }

            return head.next;
        }

        public override string ToString()
        {
            return $"[ {string.Join(", ", this.Values())} ]";
        }
    }
}
