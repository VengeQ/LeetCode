using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    // # 1187
    public class MakeArrayStrictlyIncreasing
    {
        //public class Solution
        //{
        //    public int MakeArrayIncreasing(int[] arr1, int[] arr2)
        //    {
        //        if (arr1.Length == 1)
        //        {
        //            return 0;
        //        }

        //        var sorted = new SortedDictionary<int, int>(arr2.ToDictionary(k => k, v => v));

        //        for (var i = 1; i < sorted.Count; i++)
        //        {
        //            if (arr1[i] <= arr1[i - 1])
        //            {
        //                var requiredValues = sorted.Where(value => value.Value > arr1[i - 1]);
        //                if (!requiredValues.Any())
        //                {
        //                    return -1;
        //                }

        //                var smallest = requiredValues.First();
        //                var temporal = arr1[i];
        //                arr1[i] = temporal;
        //                sorted.Remove(smallest.Key);
        //                sorted.Add(smallest.Key, arr1[i]);
        //            }
        //            else
        //            {

        //            }
        //        }

        //    }
        //}

        public class Solution
        {

            private const int COST = 2001;
            public int MakeArrayIncreasing(int[] arr1, int[] arr2)
            {
                Array.Sort(arr2);

                int result = Dfs(0, -1, arr1, arr2);

                return result < COST ? result : -1;
            }

            readonly Dictionary<(int, int), int> Store = new();

            private int Dfs(int i, int prev, int[] arr1, int[] arr2)
            {
                if (i == arr1.Length)
                {
                    return 0;
                }
                if (Store.ContainsKey((i, prev)))
                {
                    return Store[(i, prev)];
                }

                int cost = COST;

                if (arr1[i] > prev)
                {
                    cost = Dfs(i + 1, arr1[i], arr1, arr2);
                }

                int idx = BisectRight(arr2, prev);

                if (idx < arr2.Length)
                {
                    cost = Math.Min(cost, 1 + Dfs(i + 1, arr2[idx], arr1, arr2));
                }

                Store[(i, prev)] = cost;
                return cost;
            }

            private static int BisectRight(int[] arr, int value)
            {
                int left = 0, right = arr.Length;
                while (left < right)
                {
                    int mid = (left + right) / 2;
                    if (arr[mid] <= value)
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        right = mid;
                    }
                }
                return left;
            }
        }
    }
}
