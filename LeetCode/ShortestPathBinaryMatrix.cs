using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //1091
    public class ShortestPathBinaryMatrix
    {
        public class Solution
        {
            private readonly Dictionary<(int, int), bool> visited = new();
            private readonly Dictionary<(int, int), int> distances = new();
            private readonly Queue<(int, int)> queue = new();

            public int ShortestPathBinaryMatrix(int[][] grid)
            {
                // Начальная точка недоступна, сразу считаем, что пути нет
                if (grid[0][0] == 1)
                {
                    return -1;
                }

                // Заполним расстояния и флаг посещения
                for (var i = 0; i < grid.Length; i++)
                {
                    for (var j = 0; j < grid.Length; j++)
                    {
                        visited[(i, j)] = false;
                        distances[(i, j)] = -1;

                    }
                }
                visited[(0, 0)] = false;
                distances[(0, 0)] = 1;

                queue.Enqueue((0, 0));

                // Непосредственно обход
                while (queue.Any())
                {
                    var v = queue.Dequeue();

                    var neighbours = GetNeigbours(grid, v);

                    for (int i = 0; i < neighbours.Count; i++)
                    {
                        if (visited[neighbours[i]] == false)
                        {
                            distances[neighbours[i]] = distances[v] + 1;
                            visited[neighbours[i]] = true;
                            queue.Enqueue(neighbours[i]);
                        }
                    }
                }

                return distances[(grid.Length - 1, grid.Length - 1)];
            }

            // Надо было преобразовать в нормальное представление графа все-таки
            private static IList<(int, int)> GetNeigbours(int[][] grid, (int, int) vertex)
            {
                var edges = new List<(int, int)>();

                var left = (vertex.Item1 - 1, vertex.Item2);
                if (left.Item1 >= 0 && grid[left.Item1][left.Item2] == 0)
                {
                    edges.Add(left);
                }

                var right = (vertex.Item1 + 1, vertex.Item2);
                if (right.Item1 < grid.Length && grid[right.Item1][right.Item2] == 0)
                {
                    edges.Add(right);
                }

                var top = (vertex.Item1, vertex.Item2 - 1);
                if (top.Item2 >= 0 && grid[top.Item1][top.Item2] == 0)
                {
                    edges.Add(top);
                }

                var bottom = (vertex.Item1, vertex.Item2 + 1);
                if (bottom.Item2 < grid.Length && grid[bottom.Item1][bottom.Item2] == 0)
                {
                    edges.Add(bottom);
                }

                var leftTop = (vertex.Item1 - 1, vertex.Item2 - 1);
                if (leftTop.Item1 >= 0 && top.Item2 >= 0 && grid[leftTop.Item1][leftTop.Item2] == 0)
                {
                    edges.Add(leftTop);
                }

                var rightTop = (vertex.Item1 + 1, vertex.Item2 - 1);
                if (rightTop.Item1 < grid.Length && rightTop.Item2 >= 0 && grid[rightTop.Item1][rightTop.Item2] == 0)
                {
                    edges.Add(rightTop);
                }

                var leftBottom = (vertex.Item1 - 1, vertex.Item2 + 1);
                if (leftBottom.Item1 >= 0 && leftBottom.Item2 < grid.Length && grid[leftBottom.Item1][leftBottom.Item2] == 0)
                {
                    edges.Add(leftBottom);
                }

                var rightBottom = (vertex.Item1 + 1, vertex.Item2 + 1);
                if (rightBottom.Item1 < grid.Length && rightBottom.Item2 < grid.Length && grid[rightBottom.Item1][rightBottom.Item2] == 0)
                {
                    edges.Add(rightBottom);
                }

                return edges;

            }
        }
    }
}
