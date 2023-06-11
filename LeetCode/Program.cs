using LeetCode;

var x = new SnapshotArray(1);
x.Set(0, 4);
x.Set(0, 16);
x.Set(0, 13);
Console.WriteLine(x.Snap());
x.Get(0, 0);
Console.WriteLine(x.Snap());

var y = new SnapshotArray(3);
y.Set(0, 5);
Console.WriteLine(y.Snap());
y.Set(0, 6);
y.Set(0, 13);
y.Get(0, 0);
Console.WriteLine(y.Get(0, 0));


//var z = new SnapshotArray(3);
//z.Set(1, 6);
//Console.WriteLine(z.Snap());
//Console.WriteLine(z.Snap());
//z.Set(1, 19);
//z.Set(0, 4);
//Console.WriteLine(z.Get(2, 1));
//Console.WriteLine(z.Get(2, 0));
//Console.WriteLine(z.Get(0, 1));


var z = new SnapshotArray(3);
z.Set(1, 6);
Console.WriteLine(z.Snap());
Console.WriteLine(z.Snap());
z.Set(1, 19);
z.Set(0, 4);
Console.WriteLine(z.Get(2, 1));
Console.WriteLine(z.Get(2, 0));
Console.WriteLine(z.Get(0, 1));