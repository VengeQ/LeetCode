using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    // №714
    public class BuyAndSellStock
    {
        public class Solution
        {
            public int MaxProfit(int[] prices, int fee)
            {
                var free = 0;
                var hold = -prices[0];
                var temporary = 0;

                for (int i = 1; i < prices.Length; i++)
                {
                    temporary = hold;
                    hold = Math.Max(hold, free - prices[i]);
                    free = Math.Max(free, temporary + prices[i] - fee);
                }

                return Math.Max(free, hold);
            }
        }
    }
}
