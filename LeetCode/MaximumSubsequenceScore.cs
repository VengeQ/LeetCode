namespace LeetCode
{
    //2542
    internal class MaximumSubsequenceScore
    {
        public class Solution
        {
            public long MaxScore(int[] nums1, int[] nums2, int k)
            {
                if (nums1.Length == 0)
                {
                    throw new Exception();
                }

                var sortedNums2 = nums2.Select((x, i) => (x, i)).OrderBy(x => x).ToArray();
                var sortedNums1 = new int[nums1.Length].ToList();

                var counter = 0;

                foreach (var x in sortedNums2)
                {
                    sortedNums1[counter] = nums1[x.i];
                    counter++;
                }

                long result = 0L;

                if (k == 1)
                {
                    for (int j = 0; j < sortedNums2.Length; j++)
                    {
                        var newResult = sortedNums2[j].x * sortedNums1[j];
                        if (newResult > result)
                        {
                            result = newResult;
                        }
                    }
                    return result;
                }

                for (int j = 0; j < sortedNums2.Length; j++)
                {                   
                    var temporaryArray = sortedNums1.Skip(j).ToList();

                    temporaryArray.RemoveAt(0);

                    var temporary = Combinations<(int, int)>(temporaryArray.Select((x,i) => (i,x)), k - 1);

                    foreach (var r in temporary)
                    {
                        var newResult = (r.Select(v => Convert.ToInt64(v.Item2)).Sum() + sortedNums1[j]) * sortedNums2[j].x;

                        if (newResult > result)
                        {
                            result = newResult;
                        }
                    }
                }

                return result;
            }

            //Переписать итеративно 
            private static IEnumerable<IEnumerable<T>>Combinations<T>(IEnumerable<T> list, int length) where T : IComparable
            {
                if (length == 1)
                {
                    return list.Select(t => new T[] { t });
                }
             
                return 
                    Combinations(list, length - 1)
                        .SelectMany(
                            t => list.Where(
                                o => o.CompareTo(t.Last()) > 0),
                                (t1, t2) => t1.Concat(new T[] { t2 }
                            )
                        );
            }
        }
    }
}
