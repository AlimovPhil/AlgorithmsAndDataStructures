using Algorithms_Data_structures;

var myTree = new BTree();

myTree.AddItem(35);
myTree.AddItem(45);
myTree.AddItem(12);
myTree.AddItem(1);
myTree.AddItem(75);
myTree.AddItem(86);
myTree.AddItem(24);
myTree.AddItem(16);
myTree.AddItem(34);
myTree.AddItem(74);
myTree.AddItem(46);
myTree.AddItem(44);

myTree.PrintTree(myTree.Root, 1, 1);

Console.WriteLine("\nDepth First Search:");

myTree.DFS(myTree);

Console.WriteLine("\nBreadth First Search:");

myTree.BFS(myTree);


Console.WriteLine("\nЗавершение работы программы...");
Console.ReadLine();

