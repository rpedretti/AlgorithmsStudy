using Algorithms.Extensions;
using NUnit.Framework;
using System.Collections.Generic;

namespace Algorithms.Tests
{
    [TestFixture]
    public class SwapNodesInPairsTests
    {
        [TestCaseSource(nameof(TestData))]
        public IEnumerable<int> Test(ListNode list)
        {
            var response = SwapNodesInPairs.Run(list);
            return response.Values();
        }

        static IEnumerable<TestCaseData> TestData()
        {
            yield return new TestCaseData(ListNode.FromIntArray(new int[] { 1, 2, 3, 4 }))
                .Returns(new int[] { 2, 1, 4, 3 });

            yield return new TestCaseData(ListNode.FromIntArray(new int[] { 1, 2, 3, 4, 5 }))
                .Returns(new int[] { 2, 1, 4, 3, 5 });

            yield return new TestCaseData(ListNode.FromIntArray(new int[] { 1, 2, 3, 4, 5, 6 }))
                .Returns(new int[] { 2, 1, 4, 3, 6, 5 });
        }
    }
}
