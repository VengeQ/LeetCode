using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    // № 1575
    public class CountAllPossibleRoutes
    {
        public class Solution
        {
            public int CountRoutes(int[] locations, int start, int finish, int fuel)
            {
                int n = locations.Length;
                var dp = new int[n][];

                for (var i = 0; i < n; i++)
                {
                    dp[i] = new int[fuel + 1];
                }
                Array.Fill(dp[finish], 1);

                for (int j = 0; j <= fuel; j++)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int k = 0; k < n; k++)
                        {
                            if (k == i)
                            {
                                continue;
                            }
                            if (Math.Abs(locations[i] - locations[k]) <= j)
                            {
                                dp[i][j] = (dp[i][j] + dp[k][j - Math.Abs(locations[i] - locations[k])]) % 1_000_000_007;
                            }
                        }
                    }
                }

                return dp[start][fuel];
            }
        }
    }
}
