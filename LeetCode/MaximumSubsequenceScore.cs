namespace LeetCode
{
    //2542
    internal class MaximumSubsequenceScore
    {
        public class Solution
        {
            public long MaxScore(int[] nums1, int[] nums2, int k)
            {
                var dict = new (long, long)[nums1.Length];

                for (int i = 0; i < nums1.Length; i++)
                {
                    dict[i] = (nums1[i], nums2[i]);
                }

                var sortedDict = dict.OrderBy(x => x.Item2).ToArray();

                var sortedNums2 = sortedDict.Select(x => x.Item2).ToArray();
                var sortedNums1 = sortedDict.Select((x, index) => (x.Item1, index)).OrderByDescending(x => x).ToDictionary(x => x.Item2, x => x.Item1);

                var sortedNums1AsArray = sortedDict.Select((x, index) => (x.Item1, index)).OrderByDescending(x => x).ToArray();

                long sum = -1;

                if (k > nums1.Length / 2)
                {
                    sortedNums1AsArray = sortedNums1AsArray.Take(k + 1).ToArray();
                    sum = sortedNums1AsArray.Select(x => x.Item1).Sum();
                }

                long result = 0L;

                var lastIdx = 0; long _result = 0;

                for (int j = 0; j < sortedNums2.Length - k + 1; j++)
                {
                    var excluded = sortedNums1[j];
                   
                    var counter = 0;
                    
                    if ( true /*j == 0 */)
                    {
                        for (int m = 0; m < sortedNums1AsArray.Length; m++)
                        {
                            if (counter == k - 1)
                            {
                                lastIdx = m;
                                break;
                                
                            }

                            if (sortedNums1AsArray[m].index > j)
                            {
                                _result += sortedNums1AsArray[m].Item1;
                                counter++;
                            }
                        }
                    }
                    else
                    {

                        //_result -= sortedNums1AsArray[j - 1].Item1;
                        //_result += sortedNums1AsArray[lastIdx].Item1;
                       // lastIdx++;
                    }


                    var included = _result;

                    var newResult = (included + excluded) * sortedNums2[j];

                    if (newResult > result)
                    {
                        result = newResult;
                    }

                    _result = 0;
                }

                return result;
            }
        }
    }
}
