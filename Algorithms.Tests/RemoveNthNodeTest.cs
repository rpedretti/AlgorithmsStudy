using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Tests
{
    [TestFixture]
    public class RemoveNthNodeTest
    {
        [TestCaseSource(typeof(RemoveNthNodeTest), nameof(RemoveNthNodeTest.TestData))]
        public List<int> Test(ListNode head, int n)
        {
            var newHead = RemoveNthNode.Run(head, n);
            return Map(newHead);
        }

        public static IEnumerable<TestCaseData> TestData()
        {
            var node5 = new ListNode(5, null);
            var node4 = new ListNode(4, node5);
            var node3 = new ListNode(3, node4);
            var node2 = new ListNode(2, node3);
            var node1 = new ListNode(1, node2);

            yield return new TestCaseData(node1, 2).Returns(new List<int> { 1, 2, 3, 5 });
            yield return new TestCaseData(node1, 3).Returns(new List<int> { 1, 2, 4, 5 });
            yield return new TestCaseData(new ListNode(1), 1).Returns(new List<int>());
        }

        private static List<int> Map(ListNode newHead)
        {
            var values = new List<int>();
            var dummy = new ListNode(0, newHead);
            while (dummy.next != null)
            {
                values.Add(dummy.next.val);
                dummy = dummy.next;
            }

            return values;
        }
    }
}
