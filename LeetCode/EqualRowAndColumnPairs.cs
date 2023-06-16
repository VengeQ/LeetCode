using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    // №2352
    public class EqualRowAndColumnPairs
    {
        public class Solution
        {
            //brutforce
            public int EqualPairs(int[][] grid)
            {
                var result = 0;

                var length = grid.Length;

                for (int i = 0; i < length; i++)
                {
                    var row = grid[i];

                    for (var j = 0; j < length; j++)
                    {
                        for (var k = 0; k < length; k++)
                        {
                            if (grid[k][j] != row[k])
                            {
                                break;
                            }

                            if (k == length - 1 && grid[k][j] == row[k])
                            {
                                result++;
                            }
                        }
                    }
                }

                return result;
            }
        }
    }

}
