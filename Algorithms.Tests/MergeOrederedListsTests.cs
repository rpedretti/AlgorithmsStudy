using Algorithms.Extensions;
using NUnit.Framework;
using System.Collections.Generic;

namespace Algorithms.Tests
{
    [TestFixture]
    public class MergeOrederedListsTests
    {
        [TestCaseSource(nameof(TestData))]
        public IEnumerable<int> Test(ListNode l1, ListNode l2)
        {
            var values = MergeOrederedLists.Run(l1, l2).Values();
            return values;
        }

        static IEnumerable<TestCaseData> TestData()
        {
            var l1Head = ListNode.FromIntArray(new int[] { 1, 3, 4 });
            var l2Head = ListNode.FromIntArray(new int[] { 1, 2, 4 });

            yield return new TestCaseData(l1Head, l2Head).Returns(new List<int> { 
                1,1,2,3,4,4
            });
        }
    }
}
