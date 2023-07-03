using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FindAllDuplicatesArray
    {
        public class Solution
        {
            List<int> result = new();

            public IList<int> FindDuplicates(int[] nums)
                {
                for (var i = 0; i < nums.Length; i++)
                {
                    var flipIndex = Math.Abs(nums[i]) - 1;

                    if (nums[flipIndex] > 0)
                    {
                        nums[flipIndex] = -nums[flipIndex];
                    }
                    else
                    {
                        result.Add(Math.Abs(nums[i]));
                    }
                }

                return result;
            }
        }
    }
}
