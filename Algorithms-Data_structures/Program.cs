using Algorithms_Data_structures;


var List1 = new LinkedList();

List1.AddNode(11);
List1.AddNode(22);
List1.AddNode(33);
List1.AddNode(44);
List1.AddNode(55);

Console.WriteLine("List1 список узлов:");
List1.PrintAllNodes();
Console.WriteLine($"Количество узлов: {List1.GetCount()}\n");

Console.WriteLine("Добавление нового узла (66) после узла со значением (11)\n");
var requestNode = List1.FindNode(11);
List1.AddNodeAfter(requestNode, 66);

Console.WriteLine("List1 список узлов после добавления:");
List1.PrintAllNodes();
Console.WriteLine($"Количество узлов: {List1.GetCount()}\n");

Console.WriteLine("Удаление узла со значением (11) из списка:");
List1.RemoveNode(requestNode);
List1.PrintAllNodes();
Console.WriteLine($"Количество узлов: {List1.GetCount()}\n");

Console.WriteLine("Удаление узла с индексом (2) из списка:");
List1.RemoveNode(2);
List1.PrintAllNodes();
Console.WriteLine($"Количество узлов: {List1.GetCount()}\n");




Console.WriteLine("Завершение работы программы...");
Console.ReadLine();