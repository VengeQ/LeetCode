using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ReverseBits
    {
        public class Solution
        {
            public uint reverseBits(uint n)
            {   
                uint result = 0;

                for (int i = 0; i < 32; i++)
                {
                    result = (result << 1) | (n & 0b_1);
                    n >>= 1;
                }
                return result;

            }
        }
    }
}
