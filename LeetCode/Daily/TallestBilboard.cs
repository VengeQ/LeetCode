using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    // №956
    public class TallestBilboard
    {
        public class Solution
        {
            public int TallestBillboard(int[] rods)
            {
                var dp = new Dictionary<int, int>
                {
                    [0] = 0
                };

                foreach (var r in rods)
                {
                    var newDp = new Dictionary<int, int>(dp);

                    foreach (var pair in dp)
                    {
                        var diff = pair.Key;
                        var taller = pair.Value;
                        var shorter = taller - diff;

                        var newTaller = newDp.GetValueOrDefault(diff + r, 0);
                        newDp[diff + r] = Math.Max(newTaller, taller + r);

                        var newDiff = Math.Abs(shorter + r - taller);
                        var newTaller2 = Math.Max(shorter + r, taller);

                        newDp[newDiff] = Math.Max(newTaller2, newDp.GetValueOrDefault(newDiff, 0));
                    }

                    dp = newDp;
                }

                return dp.GetValueOrDefault(0, 0);
            }
        }
    }
}
