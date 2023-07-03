using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    // №347
    internal class TopKFrequentElements
    {
        public class Solution
        {
            public int[] TopKFrequent(int[] nums, int k)
            {
                var dictionary = new Dictionary<int, int>();

                foreach (int i in nums)
                {
                    if (dictionary.ContainsKey(i))
                    {
                        dictionary[i]++;
                    }
                    else
                    {
                        dictionary[i] = 1;
                    }
                }

                return dictionary
                    .OrderByDescending(x => x.Value)
                    .Take(k)
                    .Select(x => x.Key)
                    .ToArray();
            }
        }
    }
}
