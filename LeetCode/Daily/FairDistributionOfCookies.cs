using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class FairDistributionOfCookies
    {
        public class Solution
        {
            public int DistributeCookies(int[] cookies, int k)
            {
                var distribute = new int[k];

                return Traverse(0, distribute, cookies, k, 0);
            }

            private int Traverse(int i, int[] distribute, int[] cookies, int k, int count)
            {
                if (cookies.Length - i < count)
                {
                    return int.MaxValue;
                }

                if (i == cookies.Length)
                {
                    var localResult = int.MinValue;
                    foreach (var cookie in distribute)
                    {
                        localResult = Math.Max(localResult, cookie);
                    }
                    return localResult;
                }

                var result = int.MaxValue;
                for (var j = 0; j < k; j++)
                {
                    if (distribute[j] == 0)
                    {
                        count--;
                    }

                    distribute[j] += cookies[i];

                    result = Math.Min(result, Traverse(i + 1, distribute, cookies, k, count));

                    distribute[j] -= cookies[i];
                    if (distribute[j] == 0)
                    {
                        count++;
                    }
                }

                return result;
            }
        }
    }
}
