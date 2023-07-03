using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RadiusSubarrayAverages
    {
        public class Solution
        {
            public int[] GetAverages(int[] nums, int k)
            {
                if (k == 0)
                {
                    return nums;
                }

                var result = new int[nums.Length];
                long sum = 0;

                for (int i = 0; i < k && i < nums.Length; i++)
                {
                    sum += nums[i];
                    result[i] = -1;
                }

                for (int i = nums.Length - 1; i > nums.Length - 1 - k && i > 0; i--)
                {
                    result[i] = -1;
                }

                if (nums.Length - (k*2) > 0)
                {
                    var median = k + 1;
                    for (var i = k; i < median + k; i++)
                    {
                        sum += nums[i];
                    }
                    result[k] = (int)(sum / (2 * k + 1));
                }

                for (int i = k + 1; i < nums.Length && nums.Length - i > k; i++)
                {
                    sum -= nums[i - 1 - k];
                    sum += nums[i + k];
                    result[i] = (int)(sum / (2 * k + 1));
                }

                return result;
            }
        }
    }
}
