using LeetCode;
using static LeetCode.MaximumLevelSumBinaryTree;


//[[3,2,1],[1,7,6],[2,7,7]]

//1,1,0,7,-8,-7,9

var s = new NumberWaysReorder.Solution();

var result = s.NumOfWays(new int[] { 3, 4, 5, 1, 2 });

Console.WriteLine(result);