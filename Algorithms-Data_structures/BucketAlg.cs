using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Data_structures
{
    public class BucketAlg
    {
        public static int[] BubbleSort(List<int> listInput)
        {
            for (int i = 0; i < listInput.Count; i++)
            {
                for (int j = 0; j < listInput.Count; j++)
                {
                    if (listInput[i] < listInput[j])
                    {
                        var temp = listInput[i];
                        listInput[i] = listInput[j];
                        listInput[j] = temp;
                    }
                }
            }

            return listInput.ToArray();
        }
        public IEnumerable<object[]> SampleArrays()
        {
            yield return new object[] { CreateRandomArray(200), "Small Unsorted" };
            yield return new object[] { CreateRandomArray(2000), "Medium Unsorted" };
            yield return new object[] { CreateRandomArray(20000), "Large Unsorted" };
        }

        [Benchmark]
        [ArgumentsSource(nameof(SampleArrays))]
        public int[] SortArray(int[] array, string arrName)
        {
            List<int> sortedList = new();
            var minValue = array[0];
            var maxValue = array[0];
            if (array == null || array.Length <= 1)
            {
                return array;
            }
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                    maxValue = array[i];
                if (array[i] < minValue)
                    minValue = array[i];
            }

            var numberOfBuckets = maxValue - minValue + 1;
            List<int>[] bucket = new List<int>[numberOfBuckets];
            for (int i = 0; i < numberOfBuckets; i++)
            {
                bucket[i] = new List<int>();
            }

            for (int i = 0; i < array.Length; i++)
            {
                var selectedBucket = (array[i] / numberOfBuckets);
                bucket[selectedBucket].Add(array[i]);
            }
            for (int i = 0; i < numberOfBuckets; i++)
            {
                int[] temp = BubbleSort(bucket[i]);
                sortedList.AddRange(temp);
            }
            return sortedList.ToArray();
        }

        public int[] CreateRandomArray(int size)
        {
            var array = new int[size];
            var rand = new Random();
            for (int i = 0; i < size; i++)
                array[i] = rand.Next(1, size);
            return array;
        }
    }
}
