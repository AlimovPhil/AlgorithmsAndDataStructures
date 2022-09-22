using Algorithms_Data_structures;

var newGraph = new Graph();

newGraph.AddVertex("A");
newGraph.AddVertex("B");
newGraph.AddVertex("C");
newGraph.AddVertex("D");
newGraph.AddVertex("E");

newGraph.AddEdge("A", "B", 3);
newGraph.AddEdge("A", "C", 6);
newGraph.AddEdge("B", "D", 5);
newGraph.AddEdge("C", "D", 4);
newGraph.AddEdge("C", "E", 8);

Console.WriteLine(newGraph);





Console.WriteLine("Завершение работы программы...");
Console.ReadLine();