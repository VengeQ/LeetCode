using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    // №1161
    public class MaximumLevelSumBinaryTree
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        public class Solution
        {
            readonly Dictionary<int, int> nodesCounter = new();
            public int MaxLevelSum(TreeNode root)
            {
                InOrderTraversal(root, 1);

                var (level, result) = (1, int.MinValue);


                foreach (var (k, v) in nodesCounter)
                {
                    if (v == result)
                    {
                        level = Math.Min(level, k);
                    }
                    if (v > result)
                    {
                        level = k;
                        result = v;
                    }
                }

                //var (level, value) = nodesCounter.OrderBy(pair => pair.Key)
                //    .Aggregate(
                //        (level: 1, value: int.MinValue), (accumulator, pair) =>
                //            (pair.Value > accumulator.value) ? (pair.Key, pair.Value) : accumulator
                //    );

                return level;
            }

            private void InOrderTraversal(TreeNode node, int level)
            {
                if (node == null)
                {
                    return;
                }

                InOrderTraversal(node.left, level + 1);
                var isExists = nodesCounter.TryGetValue(level, out var value);
                nodesCounter[level] = isExists ? value + node.val : node.val;
                InOrderTraversal(node.right, level + 1);
            }
        }
    }
}
