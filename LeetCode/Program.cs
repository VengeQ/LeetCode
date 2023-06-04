
using LeetCode;
using System.Diagnostics;

var data = new int[][] {
    new int[]{1, 1, 0},
    new int[]{1, 1, 0},
    new int[]{0 ,0 ,1 }
};

var data2 = new int[][] {
    new int[]{1, 0, 0},
    new int[]{0, 1, 0},
    new int[]{0 ,0 ,1 }
};

var data3 = new int[][] {
    new int[]{1,0,0,1},
    new int[]{0,1,1,0},
    new int[]{ 0, 1, 1, 1 },
    new int[]{ 1, 0, 1, 1 }
};



//int n = 1;
//int headID = 0;
//var manager = new int[] { -1};
//var informTime = new int[] { 0 };

var tn = new NumberOfProvinces.Solution();


Console.WriteLine(tn.FindCircleNum(data));

Console.WriteLine(tn.FindCircleNum(data2));

Console.WriteLine(tn.FindCircleNum(data3));
