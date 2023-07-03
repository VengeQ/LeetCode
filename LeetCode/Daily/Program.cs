using LeetCode;
using static LeetCode.MaximumLevelSumBinaryTree;


var s = new String("race a car");

var t = new string(s.Where(c => char.IsLetterOrDigit(c)).ToArray());

Console.WriteLine(t);

var solution = new ValidPalindrome.Solution();

var result = solution.IsPalindrome(s);

Console.WriteLine(result);