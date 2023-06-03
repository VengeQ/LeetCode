using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TimeNeededToInformAllEmployees
    {
        public class Solution
        {
            public int NumOfMinutes(int n, int headID, int[] manager, int[] informTime)
            {
                var queue = new Queue<int>();
                var accumulatedInformTime = informTime.Select(t => 0).ToArray();

                var graph = Convert(n, manager);

                var head = headID;
                accumulatedInformTime[headID] = 0;

                queue.Enqueue(head);

                while (queue.Count > 0)
                {
                    var localHead = queue.Dequeue();

                    var isExists = graph.TryGetValue(localHead, out var neighbours);

                    if (isExists)
                    {
                        foreach (var item in neighbours)
                        {
                            accumulatedInformTime[item] += (informTime[localHead] + accumulatedInformTime[localHead]);
                            queue.Enqueue(item);
                        }
                    }
                }

                return accumulatedInformTime.Max();
            }

            public Dictionary<int, int[]> Convert(int n, int[] manager)
            {
                var vertex = new Dictionary<int, int[]>();

                for (var i = 0; i < manager.Length; i++)
                {
                    if (manager[i] != -1)
                    {
                        if (vertex.TryGetValue(manager[i], out var result))
                        {
                            var t = result.Append(i);
                            vertex[manager[i]] = t.ToArray();
                        }
                        else
                        {
                            vertex[manager[i]] = new int[] { i };
                        }


                    }
                }

                return vertex;
            }
        }
    }
}
