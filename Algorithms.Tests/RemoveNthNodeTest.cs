using Algorithms.Extensions;
using NUnit.Framework;
using System.Collections.Generic;

namespace Algorithms.Tests
{
    [TestFixture]
    public class RemoveNthNodeTest
    {
        [TestCaseSource(nameof(TestData))]
        public IEnumerable<int> Test(ListNode head, int n)
        {
            var newHead = RemoveNthNode.Run(head, n);
            return newHead.Values();
        }

        static IEnumerable<TestCaseData> TestData()
        {
            var node1 = ListNode.FromIntArray(new int[] { 1, 2, 3, 4, 5 });

            yield return new TestCaseData(node1, 2).Returns(new List<int> { 1, 2, 3, 5 });
            yield return new TestCaseData(node1, 3).Returns(new List<int> { 1, 2, 4, 5 });
            yield return new TestCaseData(new ListNode(1), 1).Returns(new List<int>());
        }
    }
}
