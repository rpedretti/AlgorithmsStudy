using NUnit.Framework;
using System.Collections.Generic;

namespace Algorithms.Tests
{
    [TestFixture]
    public class ThreeSumClosestTests
    {
        [TestCaseSource(typeof(ThreeSumClosestTests), nameof(ThreeSumClosestTests.TestData))]
        public IList<IList<int>> Test(int[] nums)
        {
            return ThreeSum.Run(nums);
        }

        public static IEnumerable<TestCaseData> TestData()
        {
            yield return new TestCaseData(new int[] { -1, 0, 1, 2, -1, -4 }).Returns(new List<IList<int>> {
                new List<int> { -1, -1, 2 },
                new List<int> { -1, 0, 1 }
            });

            yield return new TestCaseData(System.Array.Empty<int>()).Returns(new List<IList<int>> { });
            yield return new TestCaseData(new int[] { 0 }).Returns(new List<IList<int>> { });
        }
    }
}
