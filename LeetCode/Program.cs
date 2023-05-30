
using LeetCode;
using System.Diagnostics;

//[[1,[]],[-3],[-2],[-4],[0],[4]]

//var solution = new MaximumSubsequenceScore.Solution();

//var arr1 = new int[] { 1, 4 };
//var arr2 = new int[] { 3, 1 };
//var k = 2;
//var result = solution.MaxScore(arr1, arr2, k);
//Console.WriteLine(result);


//var arr11 = new int[] { 44, 10, 25, 0, 25, 49, 0 };
//var arr21 = new int[] { 18, 39, 15, 31, 43, 20, 45 };
//var k1 = 6; // 2304
//var result1 = solution.MaxScore(arr11, arr21, k1);
//Console.WriteLine(result1);

//var arr12 = new int[] { 4, 2, 3, 1, 1 };
//var arr22 = new int[] { 7, 5, 10, 9, 6 };
//var k2 = 1;
//var result2 = solution.MaxScore(arr12, arr22, k2);
//Console.WriteLine(result2);

//var arr13 = new int[] { 1, 3, 3, 2 };
//var arr23 = new int[] { 2, 1, 3, 4 };
//var k3 = 3;
//var result3 = solution.MaxScore(arr13, arr23, k3);
//Console.WriteLine(result3);

//var arr14 = new int[] { 93, 463, 179, 2488, 619, 2006, 1561, 137, 53, 1765, 2304, 1459, 1768, 450, 1938, 2054, 466, 331, 670, 1830, 1550, 1534, 2164, 1280, 2277, 2312, 1509, 867, 2223, 1482, 2379, 1032, 359, 1746, 966, 232, 67, 1203, 2474, 944, 1740, 1775, 1799, 1156, 1982, 1416, 511, 1167, 1334, 2344 };
//var arr24 = new int[] { 345, 229, 976, 2086, 567, 726, 1640, 2451, 1829, 77, 1631, 306, 2032, 2497, 551, 2005, 2009, 1855, 1685, 729, 2498, 2204, 588, 474, 693, 30, 2051, 1126, 1293, 1378, 1693, 1995, 2188, 1284, 1414, 1618, 2005, 1005, 1890, 30, 895, 155, 526, 682, 2454, 278, 999, 1417, 1682, 995 };
//var k4 = 42;
//var result4 = solution.MaxScore(arr14, arr24, k4);
//Console.WriteLine(result4);

//var arr15 = new int[50000];
//var arr25 = new int[50000];
//var k5 = 38840;

//var r = new Random();

//for (var i = 0; i < arr15.Length; i++)
//{
//    arr15[i] = r.Next(1, 50000);
//    arr15[i] = r.Next(1, 50000);
//}

//Stopwatch watch = Stopwatch.StartNew();

//var result5 = solution.MaxScore(arr15, arr15, k5);

//watch.Stop();

//Console.WriteLine(watch.ElapsedMilliseconds);

//Console.WriteLine(result5);

var summaryRange = new SummaryRanges.Solution();

var array = new int[] { 0, 1, 2, 4, 5, 7 };

var result = summaryRange.SummaryRanges(array);

foreach (var range in result)
{
    Console.WriteLine(range);
}