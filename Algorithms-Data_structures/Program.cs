using Algorithms_Data_structures;


var rnd = new Random(26);
var binSearch = new BinarySearch();
var array = new int[100];

for (int i = 0; i < array.Length; i++) // заполняем массив случайными числами от 0 до 100.
    array[i] = rnd.Next(100);

int test1 = 2; // числа которые требуется найти.
int test2 = 91;
int test3 = 150;

Array.Sort(array); // сортируем массив перед выполнением бинарного поиска.

int result = binSearch.Run(array, test1); // Ищем число 2. Оно находится в ячейке [1].
Console.WriteLine(result); // Результат 1, верно.

result = binSearch.Run(array, test2); // Ищем число 91. Оно находится в ячейке [92].
Console.WriteLine(result); // Результат 92, верно.

result = binSearch.Run(array, test3); // Ищем число 150. Его нет в данном массиве.
Console.WriteLine(result); // Результат -1 (элемент отсутствует), верно.




Console.WriteLine("Завершение работы программы...");
Console.ReadLine();