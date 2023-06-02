using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    // 2101
    public class DetonateTheMaximumBombs
    {
        public class Solution
        {
            public int MaximumDetonation(int[][] bombs)
            {
                if (bombs.Length == 0)
                {
                    return 0;
                }

                if (bombs.Length == 1)
                {
                    return 1;
                }

                var visited = bombs.Select(b => false).ToArray();
                var result = 0;

                var graph = ConvertToGraph(bombs);
                var queue = new Queue<int>();


                for (int count = 0; count< graph.Count; count++)
                {
                    visited[count] = true;

                    queue.Enqueue(count);

                    var currentCounter = 1;

                    //bfs
                    while (queue.Count > 0)
                    {
                        var v = queue.Dequeue();
                        var neighbours = graph[v];

                        for (int i = 0; i < neighbours.Count; i++)
                        {
                            if (visited[neighbours[i]] == false)
                            {
                                currentCounter++;
                                visited[neighbours[i]] = true;
                                queue.Enqueue(neighbours[i]);
                            }
                        }
                    }

                    if (currentCounter > result)
                    {
                        result = currentCounter;
                    }

                    visited = visited.Select(x => false).ToArray();
                }

                return result;
            }

            /// <summary>
            /// Представим в более удобном виде
            /// </summary>
            /// <param name="bombs"></param>
            /// <returns></returns>
            public IDictionary<int, List<int>> ConvertToGraph(int[][] bombs)
            {
                var graph = new Dictionary<int, List<int>>();

                for (var i = 0; i < bombs.Length; i++)
                {
                    var neighbours = new List<int>();
                    for (var j = 0; j < bombs.Length; j++)
                    {

                        if (IsNeighbours(bombs[i], bombs[j]))
                        {
                            neighbours.Add(j);
                        }
                    }
                    graph[i] = neighbours;

                }
                return graph;
            }

            /// <summary>
            /// Являются ли соседями (То есть сдетонирует ли первая бомба вторую)
            /// </summary>
            /// <param name="first"></param>
            /// <param name="second"></param>
            /// <returns></returns>
            public bool IsNeighbours(int[] first, int[] second)
            {
                var distance = Math.Sqrt(Math.Pow(first[0] - second[0], 2) + Math.Pow(first[1] - second[1], 2));

                return first[2] >= distance;
            }
        }
    }
}
