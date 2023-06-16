using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    // №1569
    internal class NumberWaysReorder
    {
        public class Solution
        {
            readonly long modulo = 1000_000_000L + 7;
            long[][] table;
            public int NumOfWays(int[] nums)
            {
                int m = nums.Length;

                table = new long[m][];
                for (var i = 0; i<m; i++)
                {
                    table[i] = new long[m];
                }

                for (int i = 0; i < m; ++i)
                {
                    table[i][0] = table[i][i] = 1;
                }
                for (int i = 2; i < m; i++)
                {
                    for (int j = 1; j < i; j++)
                    {
                        table[i][j] = (table[i - 1][j - 1] + table[i - 1][j]) % modulo;
                    }
                }

                return (int)((Dfs(nums.ToList()) - 1) % modulo);

            }

            private long Dfs(List<int> nums)
            {
                var length = nums.Count;

                if (length < 3)
                {
                    return 1;
                }

                List<int> left = new List<int>();
                List<int> right = new List<int>();

                for (int i = 1; i < length; i++)
                {
                    if (nums[i] < nums[0])
                    {
                        left.Add(nums[i]);
                    }
                    else
                    {
                        right.Add(nums[i]);
                    }
                }

                long leftWays = Dfs(left) % modulo;
                long rightWays = Dfs(right) % modulo;

                return (((leftWays * rightWays) % modulo) * table[length - 1][left.Count]) % modulo;
            }
        }
    }
}
