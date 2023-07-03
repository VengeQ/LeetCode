using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    //Definition for a binary tree node.


    public class MinimumAbsoluteDifferenceBST
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
            readonly List<int> nodes = new();

            public int GetMinimumDifference(TreeNode root)
            {
                InOrderTraversal(root);

                var result = int.MaxValue;

                for (var i = 1; i < nodes.Count; i++)
                {
                    var temporal = nodes[i] - nodes[i-1];
                    if( temporal < result)
                    {
                        result = temporal;
                    }
                }

                return result;
            }

            private void InOrderTraversal (TreeNode node)
            {
                if (node == null)
                {
                    return;
                }

                InOrderTraversal(node.left);
                nodes.Add(node.val);
                InOrderTraversal(node.right);
            }
        }
    }
}
