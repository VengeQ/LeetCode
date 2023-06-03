
using LeetCode;
using System.Diagnostics;

int n = 6;
int headID = 2;
var manager = new int[] { 2, 2, -1, 2, 5, 2 };
var informTime = new int[] { 0, 0, 1, 0, 0, 2 };

//int n = 1;
//int headID = 0;
//var manager = new int[] { -1};
//var informTime = new int[] { 0 };

var tn = new TimeNeededToInformAllEmployees.Solution();

Console.WriteLine(tn.NumOfMinutes(n, headID, manager, informTime));

//var converted = tn.Convert(n, headID, manager, informTime);

//Console.WriteLine(converted);
