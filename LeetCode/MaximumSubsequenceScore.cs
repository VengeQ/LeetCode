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

                var dict = new (int, int)[nums1.Length];

                for (int i = 0; i< nums1.Length; i++)
                {
                    dict[i] = (nums1[i], nums2[i]);
                }

                var sortedDict = dict.OrderBy(x => x.Item2).ToArray();

                var sortedNums2 = sortedDict.Select(x => x.Item2).ToArray();
                var sortedNums1 = sortedDict.Select((x, index) => (x.Item1, index)).OrderByDescending(x => x).ToArray();

                long result = 0L;

                for (int j = 0; j < sortedNums2.Length - k + 1; j++)
                {
                    var excluded = sortedNums1.Single(x => x.index == j).Item1;
                    var included = sortedNums1.Where(x => x.index >= j).Select(x => x.Item1).ToArray();

                    var newResult = (included.Take(k - 1).Select(v => Convert.ToInt64(v)).Sum() + excluded) * sortedNums2[j];
                    if (newResult > result)
                    {
                        result = newResult;
                    }
                }

                return result;

            }
        }
    }
}
