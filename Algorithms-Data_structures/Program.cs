using Algorithms_Data_structures;
using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run<ArrayHashSetBench>();

Console.ReadLine();

