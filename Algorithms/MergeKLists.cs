using Algorithms.Extensions;
using System.Collections.Generic;
using System.Linq;

namespace Algorithms
{
    public class MergeKLists
    {
        public static ListNode Run(IEnumerable<ListNode> lists)
        {
            var numLists = lists.Count();
            var interval = 1;

            var newList = lists.Select(n => n.CopyIter()).ToArray();

            while (interval < numLists)
            {
                for (int i = 0; i < numLists - interval; i += interval * 2)
                {
                    newList[i] = MergeOrederedLists.Run(newList[i], newList[i + interval]);
                }

                interval *= 2;
            }

            return newList[0];
        }
    }
}
