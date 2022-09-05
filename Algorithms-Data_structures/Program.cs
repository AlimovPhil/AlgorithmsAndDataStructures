using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Algorithms_Data_structures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
    }

    public class BechmarkClass
    {
        public float PointClassDistance(PointClass pointOne, PointClass pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt(x * x + y * y);
        }

        public float PointStructDistance(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return MathF.Sqrt(x * x + y * y);
        }

        public float PointStructNoSqrtDistance(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return (x * x + y * y);
        }

        public static double PointDistanceDouble(PointStruct pointOne, PointStruct pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }

        [Benchmark]
        public void TestPointRefDistance()
        {
            var point1 = new PointClass() { X = (float)12.5455, Y = (float)32.7723 };
            var point2 = new PointClass() { X = (float)53.2275, Y = (float)16.6629 };
            PointClassDistance(point1, point2);
        }

        [Benchmark]
        public void TestPointValueDistance()
        {
            var point1 = new PointStruct() { X = (float)12.5455, Y = (float)32.7723 };
            var point2 = new PointStruct() { X = (float)53.2275, Y = (float)16.6629 };
            PointStructDistance(point1, point2);
        }
        [Benchmark]
        public void TestPointStructNoSqrtDistance()
        {
            var point1 = new PointStruct() { X = (float)12.5455, Y = (float)32.7723 };
            var point2 = new PointStruct() { X = (float)53.2275, Y = (float)16.6629 };
            PointStructNoSqrtDistance(point1, point2);
        }
        [Benchmark]
        public void TestPointDistanceDouble()
        {
            var point1 = new PointStruct() { X = (float)12.5455, Y = (float)32.7723 };
            var point2 = new PointStruct() { X = (float)53.2275, Y = (float)16.6629 };
            PointDistanceDouble(point1, point2);
        }
    }
}