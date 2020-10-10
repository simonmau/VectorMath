using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using VectorMath.Vector;

namespace VectorMath.Tests.Vector
{
    public class SerializationTests
    {
        [Test]
        public void TestSerializationSingleItemNewtonsoftJson()
        {
            var rand = new Random();

            var v1 = new Vector2D(rand.NextDouble(), rand.NextDouble());

            Assert.DoesNotThrow(() =>
            {
                JsonConvert.SerializeObject(v1);
            });
        }

        [Test]
        public void TestSerializationListNewtonsoftJson()
        {
            var rand = new Random();

            var list = new List<Vector2D>();

            for (int i = 0; i < 100; i++)
            {
                list.Add(new Vector2D(rand.NextDouble(), rand.NextDouble()));
            }

            Assert.DoesNotThrow(() =>
            {
                JsonConvert.SerializeObject(list);
            });
        }

        [Test]
        public void TestDeserializationSingleItemNewtonsoftJson()
        {
            var rand = new Random();

            var v1 = new Vector2D(rand.NextDouble(), rand.NextDouble());

            var serItem = JsonConvert.SerializeObject(v1);

            Assert.DoesNotThrow(() =>
            {
                JsonConvert.DeserializeObject<Vector2D>(serItem);
            });

            Vector2D deSer = JsonConvert.DeserializeObject<Vector2D>(serItem);

            Assert.AreEqual(v1.X, deSer.X);
            Assert.AreEqual(v1.Y, deSer.Y);
        }

        [Test]
        public void TestDeserializationListNewtonsoftJson()
        {
            var rand = new Random();

            var list = new List<Vector2D>();

            for (int i = 0; i < 100; i++)
            {
                list.Add(new Vector2D(rand.NextDouble(), rand.NextDouble()));
            }

            var serItem = JsonConvert.SerializeObject(list);

            Assert.DoesNotThrow(() =>
            {
                JsonConvert.DeserializeObject<List<Vector2D>>(serItem);
            });

            var deSer = JsonConvert.DeserializeObject<List<Vector2D>>(serItem);

            for (int i = 0; i < 100; i++)
            {
                Assert.AreEqual(list[i].X, deSer[i].X);
                Assert.AreEqual(list[i].Y, deSer[i].Y);
            }
        }
    }
}