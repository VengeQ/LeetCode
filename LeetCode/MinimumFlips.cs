using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //1318
    public class MinimumFlips
    {
        public class Solution
        {
            public int MinFlips(int a, int b, int c)
            {
                var flips = (a | b) ^ c;
                var extraFlips = (a & b) & ((a | b) ^ c);

                return BitOperations.PopCount((uint)flips) + BitOperations.PopCount((uint)extraFlips);
            }
        }
    }
}
