using NUnit.Framework;
using VectorMath.Vector;

namespace VectorMath.Tests.Vector
{
    public class Vector3dBaseArithmeticTests_Subtract
    {
        [Test]
        public void TestSubtract_1()
        {
            var v1 = new Vector3D(1d, 2d, 5d);
            var v2 = new Vector3D(3d, 7d, 6d);

            var v3 = v1 - v2;

            Assert.AreEqual(-2d, v3.X);
            Assert.AreEqual(-5d, v3.Y);
            Assert.AreEqual(-1d, v3.Z);
        }

        [Test]
        public void TestSubtract_2()
        {
            var v1 = new Vector3D(1d, 2d, 3d);
            v1.Subtract(29d);

            Assert.AreEqual(-28d, v1.X);
            Assert.AreEqual(-27d, v1.Y);
            Assert.AreEqual(-26d, v1.Z);
        }

        [Test]
        public void TestSubtract_3()
        {
            var v1 = new Vector3D(1d, 2d, 3d);
            var v2 = v1 - 29d;

            Assert.AreEqual(-28d, v2.X);
            Assert.AreEqual(-27d, v2.Y);
            Assert.AreEqual(-26d, v2.Z);
        }

        [Test]
        public void TestSubtract_4()
        {
            var v1 = new Vector3D(1d, 2d, 5d);
            var v2 = new Vector3D(3d, 7d, 6d);

            v1.Subtract(v2);

            Assert.AreEqual(-2d, v1.X);
            Assert.AreEqual(-5d, v1.Y);
            Assert.AreEqual(-1d, v1.Z);
        }
    }
}