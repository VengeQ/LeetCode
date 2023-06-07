using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //№1232
    public class CheckStraightLine
    {
        public class Solution
        {
            public bool CheckStraightLine(int[][] coordinates)
            {
                if (coordinates.Length == 2)
                {
                    return true;
                }

                var denominator = (double)coordinates[0][0] - coordinates[1][0];

                // Частный случай. Прямая параллельная оси ординат
                if (denominator == 0)
                {
                    var offset = coordinates[0][0];
                    for (var i = 2; i < coordinates.Length; i++)
                    {
                        if (coordinates[i][0] != offset)
                        {
                            return false;
                        }
                    }
                    return true;
                }

                double k = (coordinates[0][1] - coordinates[1][1]) / denominator;
                double b = coordinates[0][1] - k * coordinates[0][0];

                for (var i = 2; i < coordinates.Length; i++)
                {
                    if (k * coordinates[i][0] + b != coordinates[i][1])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
