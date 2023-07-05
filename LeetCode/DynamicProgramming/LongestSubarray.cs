using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DynamicProgramming
{
    // №1493
    public class LongestSubarray
    {
        public class Solution
        {
            public int LongestSubarray(int[] nums)
            {
                if (nums == null)
                {
                    throw new ArgumentNullException(nameof(nums), "Входной параметр не должен быть равен нулю");
                }

                if (nums.Length == 0)
                {
                    throw new ArgumentException("Длина массива должна быть больше 0");
                }

                if (nums.Length > 100000)
                {
                    throw new ArgumentException("Длина массива не должна превышать 100000");
                }

                if (nums.Any(x => x != 0 && x != 1))
                {
                    throw new ArgumentException("Во входном массиве все элементы должны быть 0 или 1");
                }

                if (nums.Length == 1)
                {
                    return nums[0];
                }

                var result = 0;
                var current = 0;
                var inseparablePart = 0;

                for (var i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == 0)
                    {
                        result = Math.Max(result, current);
                        current = inseparablePart;
                        inseparablePart = 0;                       
                    }
                    else
                    {
                        current++;
                        inseparablePart++;
                    }                   
                }

                result = Math.Max(result, current);
                return Math.Min(result, nums.Length - 1);
            }
        }
    }
}
