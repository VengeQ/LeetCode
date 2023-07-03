using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    // №2448
    public class MinimumCostToMakeArrayEqual
    {
        class Solution
        {
            public long MinCost(int[] nums, int[] cost)
            {
                int left = 1_000_001, right = 0;
                foreach (int num in nums)
                {
                    left = Math.Min(left, num);
                    right = Math.Max(right, num);
                }
                long answer = GetCost(nums, cost, nums[0]);

                while (left < right)
                {
                    int mid = (right + left) / 2;
                    long cost1 = GetCost(nums, cost, mid);
                    long cost2 = GetCost(nums, cost, mid + 1);
                    answer = Math.Min(cost1, cost2);

                    if (cost1 > cost2)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid;
                    }   
                }
                return answer;
            }

            private long GetCost(int[] nums, int[] cost, int basis)
            {
                long result = 0L;
                for (int i = 0; i < nums.Length; ++i)
                {
                    result += (long)Math.Abs(nums[i] - basis) * cost[i];
                }
                return result;
            }
        }
    }
}
