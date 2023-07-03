using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.DynamicProgramming
{
    public class FibonacciNumber
    {
        public class Solution
        {
            public int Fib(int n)
            {
                if (n == 0)
                {
                    return 0;
                }

                if (n == 1)
                {
                    return 1;
                }

                var first = 0;
                var second = 1;
                var counter = 2;
                int temporary;

                while (counter <= n)
                {
                    temporary = second;
                    second += first;
                    first = temporary;
                    counter++;
                }

                return second;
            }
        }
    }
}
