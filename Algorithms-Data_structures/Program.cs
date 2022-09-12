﻿using Algorithms_Data_structures;

var myTree = new BTree();
myTree.AddItem(35);
myTree.AddItem(45);
myTree.AddItem(12);
myTree.AddItem(1);
myTree.AddItem(75);
myTree.AddItem(86);
myTree.AddItem(24);
myTree.AddItem(16);
myTree.PrintTree(myTree.Root,1,1);

myTree.RemoveItem(86, myTree.Root);
myTree.PrintTree(myTree.Root, 1, 10);

myTree.RemoveItem(24, myTree.Root);
myTree.PrintTree(myTree.Root, 1, 20);

//Console.WriteLine("Завершение работы программы...");
Console.ReadLine();

