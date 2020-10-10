using BenchmarkDotNet.Attributes;

namespace VectorMath.Benchmark.Vector2D
{
    [MemoryDiagnoser]
    [ThreadingDiagnoser]
    public class CrossProductTestRunner
    {
        private static double _x = 53.565249314563;
        private static double _y = 13.28756972336;
        private static double _z = 36.31264891823;

        [Benchmark]
        public double TestNGenerics()
        {
            var v1 = new NGenerics.DataStructures.Mathematical.Vector3D(_x, _y, _z);
            v1.CrossProduct(NGenerics.DataStructures.Mathematical.Vector3D.UnitVector);

            return v1.X;
        }

        [Benchmark]
        public double TestVectorMath()
        {
            var v1 = new Vector.Vector3D(_x, _y, _z);
            v1.CrossProduct(Vector.Vector3D.UnitVector);

            return v1.X;
        }
    }
}