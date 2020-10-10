using NUnit.Framework;
using VectorMath.Vector;

namespace VectorMath.Tests.Vector
{
    public class Vector2dBaseArithmeticTests_Add
    {
        [Test]
        public void TestAdd_1()
        {
            var v1 = new Vector2D(1d, 2d);
            var v2 = new Vector2D(3d, 4d);

            var v3 = v1 + v2;

            Assert.AreEqual(4d, v3.X);
            Assert.AreEqual(6d, v3.Y);
        }

        [Test]
        public void TestAdd_2()
        {
            var v1 = new Vector2D(1d, 2d);
            v1.Add(29d);

            Assert.AreEqual(30d, v1.X);
            Assert.AreEqual(31d, v1.Y);
        }

        [Test]
        public void TestAdd_3()
        {
            var v1 = new Vector2D(1d, 2d);
            var v2 = v1 + 29d;

            Assert.AreEqual(30d, v2.X);
            Assert.AreEqual(31d, v2.Y);
        }

        [Test]
        public void TestAdd_4()
        {
            var v1 = new Vector2D(1d, 2d);
            var v2 = new Vector2D(3d, 4d);

            v1.Add(v2);

            Assert.AreEqual(4d, v1.X);
            Assert.AreEqual(6d, v1.Y);
        }
    }
}