using BenchmarkDotNet.Attributes;

namespace VectorMath.Benchmark.Vector2D
{
    [MemoryDiagnoser]
    [ThreadingDiagnoser]
    public class DivisionTestRunner
    {
        private static double _factor = 1.23456789;
        private static double _x = 53.565249314563;
        private static double _y = 13.28756972336;

        [Benchmark]
        public double TestNGenerics()
        {
            var v1 = new NGenerics.DataStructures.Mathematical.Vector2D(_x, _y);
            v1.Divide(_factor);

            return v1.X;
        }

        [Benchmark]
        public double TestVectorMath()
        {
            var v1 = new Vector.Vector2D(_x, _y);
            v1.Divide(_factor);

            return v1.X;
        }

        [Benchmark]
        public double TestMathNet()
        {
            var v1 = MathNet.Numerics.LinearAlgebra.Vector<double>.Build.DenseOfArray(new[] { _x, _y });
            var v2 = v1.Divide(_factor);

            return v2[0];
        }
    }
}