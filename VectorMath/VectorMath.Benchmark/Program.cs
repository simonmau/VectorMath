using BenchmarkDotNet.Running;
using System;
using VectorMath.Benchmark.Vector2D;

namespace VectorMath.Benchmark
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<CrossProductTestRunner>();
            Console.WriteLine(summary);
            Console.ReadLine();
        }
    }
}