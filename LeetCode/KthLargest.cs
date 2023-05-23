using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //public class KthLargest
    //{

    //    private List<int> sortedList;
    //    private int index;

    //    public KthLargest(int k, int[] nums)
    //    {
    //        index = k;
    //        sortedList = nums.OrderBy(i => i).ToList();
    //    }

    //    public int Add(int val)
    //    {
    //        sortedList.Add(val);
    //        sortedList.Sort();
    //        return sortedList[sortedList.Count - (index )];
    //    }
    //}

    public class KthLargest
    {
        private LinkedList<int> minList;
        private int index;

        public KthLargest(int k, int[] nums)
        {
            index = k;
            minList = new LinkedList<int>(nums.OrderByDescending(i => i).Take(index));
        }

        public int Add(int val)
        {
            if (minList.Count < index)
            {
                var initElement = minList.First;
                if (initElement == null)
                {
                    minList.AddFirst(val);
                    return val;
                }

                while (true)
                {
                    if (initElement == null)
                    {
                        minList.AddLast(val);
                        return minList.Take(index).Last();
                    }
                    else if (initElement.Value < val)
                    {
                        minList.AddBefore(initElement, val);
                        return minList.Take(index).Last();
                    }                    
                    initElement = initElement.Next;
                }
            }

            var counter = 0;

            var element = minList.First;

            if (element == null)
            {
                minList.AddFirst(val);
                return val;
            }


            while (element!= null)
            {
                if (counter >= index)
                {
                    break;
                }
                counter++;

                if (element.Value < val)
                {
                    minList.AddBefore(element, new LinkedListNode<int>(val));
                    break;
                }
                else
                {
                    element = element.Next;
                }
            }

            return minList.Take(index).Last();
        }
    }

}
