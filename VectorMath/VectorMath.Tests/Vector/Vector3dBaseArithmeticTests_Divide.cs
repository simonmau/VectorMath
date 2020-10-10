using NUnit.Framework;
using VectorMath.Vector;

namespace VectorMath.Tests.Vector
{
    public class Vector3dBaseArithmeticTests_Divide
    {
        [Test]
        public void TestDivide_1()
        {
            var v1 = new Vector3D(6d, 9d, 12d);

            var v3 = v1 / 3d;

            Assert.AreEqual(2d, v3.X);
            Assert.AreEqual(3d, v3.Y);
            Assert.AreEqual(4d, v3.Z);
        }

        [Test]
        public void TestDivide_2()
        {
            var v1 = new Vector3D(10d, 2d, 6d);
            v1.Divide(2d);

            Assert.AreEqual(5d, v1.X);
            Assert.AreEqual(1d, v1.Y);
            Assert.AreEqual(3d, v1.Z);
        }
    }
}