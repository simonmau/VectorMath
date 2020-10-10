using NUnit.Framework;
using VectorMath.Vector;

namespace VectorMath.Tests.Vector
{
    public class Vector2dBaseArithmeticTests_Subtract
    {
        [Test]
        public void TestSubtract_1()
        {
            var v1 = new Vector2D(1d, 2d);
            var v2 = new Vector2D(3d, 5d);

            var v3 = v1 - v2;

            Assert.AreEqual(-2d, v3.X);
            Assert.AreEqual(-3d, v3.Y);
        }

        [Test]
        public void TestSubtract_2()
        {
            var v1 = new Vector2D(1d, 2d);
            v1.Subtract(29d);

            Assert.AreEqual(-28d, v1.X);
            Assert.AreEqual(-27d, v1.Y);
        }

        [Test]
        public void TestSubtract_3()
        {
            var v1 = new Vector2D(1d, 2d);
            var v2 = v1 - 29d;

            Assert.AreEqual(-28d, v2.X);
            Assert.AreEqual(-27d, v2.Y);
        }

        [Test]
        public void TestSubtract_4()
        {
            var v1 = new Vector2D(1d, 2d);
            var v2 = new Vector2D(3d, 5d);

            v1.Subtract(v2);

            Assert.AreEqual(-2d, v1.X);
            Assert.AreEqual(-3d, v1.Y);
        }
    }
}