//Реализовать Bucketsort, проверить корректность работы.

using Algorithms_Data_structures;
using BenchmarkDotNet.Running;

//var array = new int[] { 73, 57, 49, 99, 133, 20, 1 };
//var sortFunc = new BucketAlg();
//var result = sortFunc.SortArray(array); // 1, 20, 49, 57, 73, 99, 133
//for (int i = 0; i < result.Length; i++)
//    Console.Write(result[i]+" ");
//Console.WriteLine("");

//var array1 = sortFunc.CreateRandomArray(50);
//for (int i = 0; i < array1.Length; i++)
//    Console.Write(array1[i] + " ");

//Console.WriteLine("");

//result = sortFunc.SortArray(array1);
//for (int i = 0; i < result.Length; i++)
//    Console.Write(result[i] + " ");

var summary = BenchmarkRunner.Run<BucketAlg>();