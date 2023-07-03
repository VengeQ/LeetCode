using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class MedianOfTwoSortedArrays
    {
        public class Solution
        {
            public double FindMedianSortedArrays(int[] nums1, int[] nums2)
            {
                var length = nums1.Length + nums2.Length;
                var isEven = length % 2 == 0;
                var firstPointer = nums1[0];
                var secondPointer = nums2[0];

                //if (isEven)
                //{
                //    for (var i = 0; i<)
                //}

                return 0;
            }
        }
    }
}
