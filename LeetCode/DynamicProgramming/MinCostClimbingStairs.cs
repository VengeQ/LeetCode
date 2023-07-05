using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DynamicProgramming
{
    // № 746
    public class MinCostClimbingStairs
    {
        public class Solution
        {
            public int MinCostClimbingStairs(int[] cost)
            {
                if (cost.Length < 2)
                {
                    throw new ArgumentException("Длина входного массива должна быть больше 1.");
                }

                if (cost.Length > 1000)
                {
                    throw new ArgumentException("Длина входного массива должна быть меньше 1000.");
                }

                int temporary;
                var twoStepBehind = cost[0];
                var oneStepBehind = cost[1];

                for (int i = 2; i < cost.Length; i++)
                {
                    temporary = Math.Min(twoStepBehind + cost[i], oneStepBehind + cost[i]);
                    twoStepBehind = oneStepBehind;
                    oneStepBehind = temporary;
                }

                return Math.Min(twoStepBehind, oneStepBehind);
            }
        }
    }
}
