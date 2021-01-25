using System;
using System.Linq;

namespace Algorithms
{
    public static class ThreeSumClosest
    {
        public static int Run(int[] nums, int target)
        {
            var totalCount = nums.Length;

            if (totalCount < 3) return 0; // if nums less than 3 element

            var sorted = nums.ToArray();

            Array.Sort(sorted);

            int? sum = null;

            for (int i = 0; i < totalCount - 2; i++)
            {
                if (i > 0 && sorted[i - 1] == sorted[i]) continue;

                int j = i + 1;
                int k = totalCount - 1;

                while (j < k)
                {
                    var newSum = sorted[i] + sorted[j] + sorted[k];

                    if (newSum > target)
                    {
                        k--;
                        while (j < k && sorted[k] == sorted[k + 1])
                        {
                            k--;
                        }
                    }
                    else if (newSum < target)
                    {
                        j++;
                        while (j < k && sorted[j] == sorted[j - 1])
                        {
                            j++;
                        }
                    }
                    else
                    {
                        return newSum;
                    }

                    sum = Math.Abs(target - newSum) < Math.Abs(target - (sum ?? newSum)) ? newSum : sum ?? newSum;
                }
            }

            return sum.Value;
        }
    }
}
