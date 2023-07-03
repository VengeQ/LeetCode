using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MaximumLinkedListTwinSum
    {
        public class Solution
        {
            public int PairSum(ListNode head)
            {
                var array = new List<int>(10000);

                while (head != null)
                {
                    array.Add(head.val);
                    head = head.next;
                }

                var result = array[0] + array[^1];

                for (int i = 0; i < array.Count / 2; i++)
                {
                    var newResult = array[i] + array[^(1 + i)];
                    if (newResult > result)
                    {
                        result = newResult; 
                    }
                }

                return result;
            }
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

    }
}
