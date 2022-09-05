namespace Algorithms_Data_structures.Lesson2;

public class BinarySearch
{
    public int Run(int[] inputArray, int searchValue)
    {
        int min = 0;
        int max = inputArray.Length - 1;
        while (min <= max)
        {
            int mid = (min + max) / 2;
            if (searchValue == inputArray[mid])
            {
                return mid;
            }
            else if (searchValue < inputArray[mid])
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }
        return -1; // Возвращает -1, если поиск не дал результатов.
    }

}
// Асимптотическая сложность функции: O(log n)