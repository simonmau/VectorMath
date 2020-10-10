using NUnit.Framework;
using VectorMath.Vector;

namespace VectorMath.Tests.Vector
{
    public class Vector2dBaseArithmeticTests_Divide
    {
        [Test]
        public void TestDivide_1()
        {
            var v1 = new Vector2D(6d, 9d);

            var v = v1 / 3d;

            Assert.AreEqual(2d, v.X);
            Assert.AreEqual(3d, v.Y);
        }

        [Test]
        public void TestDivide_2()
        {
            var v1 = new Vector2D(4d, 2d);

            v1.Divide(2d);

            Assert.AreEqual(2d, v1.X);
            Assert.AreEqual(1d, v1.Y);
        }
    }
}