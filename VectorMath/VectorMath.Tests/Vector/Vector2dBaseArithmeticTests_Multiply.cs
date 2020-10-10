using NUnit.Framework;
using VectorMath.Vector;

namespace VectorMath.Tests.Vector
{
    public class Vector2dBaseArithmeticTests_Multiply
    {
        [Test]
        public void TestMultiply_1()
        {
            var v1 = new Vector2D(1d, 2d);

            var v = v1 * 3d;

            Assert.AreEqual(3d, v.X);
            Assert.AreEqual(6d, v.Y);
        }

        [Test]
        public void TestMultiply_2()
        {
            var v1 = new Vector2D(1d, 2d);

            v1.Multiply(3d);

            Assert.AreEqual(3d, v1.X);
            Assert.AreEqual(6d, v1.Y);
        }
    }
}