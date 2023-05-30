using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //228
    internal class SummaryRanges
    {
        public class Solution
        {
            public IList<string> SummaryRanges(int[] nums)
            {
                if (nums.Length == 0)
                {
                    return new List<string>();
                } 

                if (nums.Length == 1)
                {
                    return new List<string>() { nums[0].ToString() };
                }

                var resultRanges = new List<string>();

                var currentRange = new List<int>
                {
                    nums[0]
                };

                for (int i = 1; i < nums.Length; i++)
                {
                    if (nums[i] != currentRange[^1] + 1)
                    {
                        resultRanges.Add(currentRange.Count == 1 ? currentRange[0].ToString() : $"{currentRange[0]}->{currentRange[^1]}");
                        currentRange.Clear();
                    }
                    currentRange.Add(nums[i]);

                }

                resultRanges.Add(currentRange.Count == 1 ? currentRange[0].ToString() : $"{currentRange[0]}->{currentRange[^1]}");

                return resultRanges;
            }
        }
    }
}
