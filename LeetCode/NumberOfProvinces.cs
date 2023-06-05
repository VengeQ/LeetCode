using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //№547
    public class NumberOfProvinces
    {
        public class Solution
        {
            public int FindCircleNum(int[][] isConnected)
            {
                var visited = isConnected.Select(x => false).ToList();
                var queue = new Queue<int>();
                var provinceCounter = 0;

                while (visited.Any(v => v == false))
                {
                    queue.Enqueue(visited.IndexOf(false));
                    provinceCounter++;

                    while (queue.Count > 0)
                    {
                        var city = queue.Dequeue();
                        visited[city] = true;

                        var neighbours = isConnected[city].Select((item, index) => (item, index)).Where(x => x.item == 1 && x.index != city);

                        foreach (var item in neighbours)
                        {
                            if (visited[item.index] == false)
                            {
                                visited[item.index] = true;
                                queue.Enqueue(item.index);
                            }
                        }

                    }
                }
                return provinceCounter;
            }
        }
    }
}
