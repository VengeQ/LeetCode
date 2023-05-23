
using LeetCode;

//[[1,[]],[-3],[-2],[-4],[0],[4]]

var solution = new KthLargest(3, new int[] { 4, 5, 8, 2 });

Console.WriteLine(solution.Add(3));
Console.WriteLine(solution.Add(5));
Console.WriteLine(solution.Add(10));
Console.WriteLine(solution.Add(9));
Console.WriteLine(solution.Add(5));

var solution1 = new KthLargest(1, new int[] { });

Console.WriteLine(solution1.Add(-3));
Console.WriteLine(solution1.Add(-2));
Console.WriteLine(solution1.Add(-4));
Console.WriteLine(solution1.Add(0));
Console.WriteLine(solution1.Add(4));

var solution2 = new KthLargest(2, new int[] { 0 });

Console.WriteLine(solution2.Add(-1));
Console.WriteLine(solution2.Add(1));
Console.WriteLine(solution2.Add(-2));
Console.WriteLine(solution2.Add(-4));
Console.WriteLine(solution2.Add(3));