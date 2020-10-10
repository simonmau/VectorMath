using NUnit.Framework;
using VectorMath.Vector;

namespace VectorMath.Tests.Vector
{
    public class Vector3dBaseArithmeticTests_Multiply
    {
        [Test]
        public void TestMultiply_1()
        {
            var v1 = new Vector3D(1d, 2d, 5d);

            var v3 = v1 * 3d;

            Assert.AreEqual(3d, v3.X);
            Assert.AreEqual(6d, v3.Y);
            Assert.AreEqual(15d, v3.Z);
        }

        [Test]
        public void TestMultiply_2()
        {
            var v1 = new Vector3D(1d, 2d, 3d);
            v1.Multiply(2d);

            Assert.AreEqual(2d, v1.X);
            Assert.AreEqual(4d, v1.Y);
            Assert.AreEqual(6d, v1.Z);
        }
    }
}