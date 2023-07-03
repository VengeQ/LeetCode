using System;
using System.Collections.Generic;
using System.Linq;


namespace LeetCode.DynamicProgramming
{
    public class TribonacciNumber
    {
        public class Solution
        {
            public int Tribonacci(int n)
            {
                return TribonacciRecursive(0, 1, 1, n);
            }

            private int TribonacciRecursive(int first, int second, int third, int n)
            {
                return n switch
                {
                    0 => first,
                    int x when x > 0 && x <= 37 => TribonacciRecursive(second, third, first + second + third, n - 1),
                    _ => throw new ArgumentException("n should be between 0 and 37", nameof(n))
                };
            }
        }
    }
}
