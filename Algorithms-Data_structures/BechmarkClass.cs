using BenchmarkDotNet.Attributes;

namespace Algorithms_Data_structures;

public class ArrayHashSetBench
{
    public const string str1 = "rcv";
    public const string str2 = "koo";

    public HashSet<string> hashSet = new();
    public string[] arr = new string[10000];
    public Random rnd = new(10);

    public static bool HashSetSearch(string search_str, HashSet<string> hashSet, int str_count, Random random)
    {
        do
        {
            string value = default;

            for (int i = 0; i < random.Next(3, 6); i++)            //генерация строк с символами с помощью Random()
            {
                value += ((char)random.Next('a', 'z')).ToString();
                hashSet.Add(value);
            }
        }
        while (hashSet.Count < str_count);
        return hashSet.Contains(search_str);
    }
    public static bool ArraySearch(string search_str, string[] array, Random random)
    {
        int i = -1;
        while (i++ < 9999)
        {
            string value = "";
            for (int j = 0; j < random.Next(3, 6); j++)
            {
                value += ((char)random.Next('a', 'z')).ToString();
                array[i] = value;
            }
        }
        return array.Contains(search_str);
    }

    [Benchmark]
    public void TestHashSetSearch()
    {
        HashSetSearch(str1, hashSet, 10000, rnd);
    }

    [Benchmark]
    public void TestArraySearch()
    {
        ArraySearch(str1, arr, rnd);
    }
}
