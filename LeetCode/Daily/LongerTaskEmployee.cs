using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    // №2434
    public class LongerTaskEmployee
    {
        public class Solution
        {
            public int HardestWorker(int n, int[][] logs)
            {
                var result = (logs[0][0], logs[0][1]);

                for (int i = 1; i < logs.Length; i++)
                {
                    var duration = logs[i][1] - logs[i - 1][1];
                    var employeeId = logs[i][0];

                    if (duration > result.Item2)
                    {
                        result = (employeeId, duration);
                    }
                    else if (duration == result.Item2)
                    {
                        result = (Math.Min(employeeId, result.Item1), duration);
                    }


                }

                return result.Item1;
            }
        }
    }
}
