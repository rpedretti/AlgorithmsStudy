using Algorithms.Extensions;
using NUnit.Framework;
using System.Collections.Generic;

namespace Algorithms.Tests
{
    [TestFixture]
    public class MergeKListsTests
    {
        [TestCaseSource(nameof(TestData))]
        public IEnumerable<int> Test(ListNode[] lists)
        {
            var result = MergeKLists.Run(lists);
            return result.Values();
        }

        static IEnumerable<TestCaseData> TestData()
        {
            var head1 = ListNode.FromIntArray(new int[] { 1, 4, 5 });
            var head2 = ListNode.FromIntArray(new int[] { 1, 3, 4 });
            var head3 = ListNode.FromIntArray(new int[] { 2, 6 });

            yield return new TestCaseData(new[] { new ListNode[] { head1, head2, head3 } })
                .Returns(new int[] { 1, 1, 2, 3, 4, 4, 5, 6 });
        }
    }
}
