using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public static class ThreeSum
    {
        public static IList<IList<int>> Run(int[] nums)
        {
            var result = new List<IList<int>>();

            var totalCount = nums.Length;

            if (totalCount < 3) return result; // if nums less than 3 element

            var sorted = nums.ToArray();

            Array.Sort(sorted);

            for (int i = 0; i < totalCount - 2; i++)
            {
                var target = -sorted[i];

                if (i > 0 && sorted[i - 1] == sorted[i]) continue;

                int j = i + 1;
                int k = totalCount - 1;

                while (j < k)
                {
                    var sum = sorted[j] + sorted[k];

                    if (sum > target)
                    {
                        k--;
                        while (j < k && sorted[k] == sorted[k + 1])
                        {
                            k--;
                        }
                    }
                    else if (sum < target)
                    {
                        j++;
                        while (j < k && sorted[j] == sorted[j - 1])
                        {
                            j++;
                        }
                    }
                    else
                    {
                        var list = new int[] { sorted[i], sorted[j], sorted[k] };
                        result.Add(list);
                        j++;

                        while (j < k && sorted[j] == sorted[j - 1])
                        {
                            j++;
                        }
                    }
                }
            }

            return result;
        }
    }
}
