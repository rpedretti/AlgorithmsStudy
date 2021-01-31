using NUnit.Framework;
using System.Collections.Generic;

namespace Algorithms.Tests
{
    [TestFixture]
    public class ThreeSumClosestTest
    {
        [TestCaseSource(nameof(TestData))]
        public int Test(int[] nums, int target)
        {
            return ThreeSumClosest.Run(nums, target);
        }

        static IEnumerable<TestCaseData> TestData()
        {
            yield return new TestCaseData(new int[] { -1, 2 }, 0).Returns(0);
            yield return new TestCaseData(new int[] { -1, 2, 1, -4 }, 1).Returns(2);
            yield return new TestCaseData(new int[] { -2, 1, 3, -5 }, 2).Returns(2);
            yield return new TestCaseData(new int[] { -2, 1, 3, -2 }, -3).Returns(-3);
            yield return new TestCaseData(new int[] { 2, 1, 3, -2, -4, 8 }, 5).Returns(5);
            yield return new TestCaseData(new int[] { -2, -1, 1, 1, 2, 2, 7, 7 }, 3).Returns(3);
        }
    }
}
