using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class NumberOfIncreasingPathsInGrid
    {
        public class Solution
        {
            int[][]? dp;
            readonly int[][] directions = new int[][] { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { 1, 0 }, new int[] { -1, 0 } };
            readonly int modulo = 1_000_000_007;

            int Dfs(int[][] grid, int i, int j)
            {
                if (dp[i][j] != 0)
                {
                    return dp[i][j];
                }

                int result = 1;

                foreach (var direction in directions)
                {
                    int prevI = i + direction[0], prevJ = j + direction[1];
                    if (0 <= prevI && prevI < grid.Length && 0 <= prevJ && prevJ < grid[0].Length && grid[prevI][prevJ] < grid[i][j])
                    {
                        result += Dfs(grid, prevI, prevJ);
                        result %= modulo;
                    }
                }

                dp[i][j] = result;
                return result;
            }

            public int CountPaths(int[][] grid)
            {
                int m = grid.Length, n = grid[0].Length;
                dp = new int[m][];

                for (var c = 0; c < m; c++)
                {
                    dp[c] = new int[n];
                }

                int result = 0;
                for (int i = 0; i < m; ++i)
                {
                    for (int j = 0; j < n; ++j)
                    {
                        result = (result + Dfs(grid, i, j)) % modulo;
                    }
                }

                return result;
            }
        }
    }
}
