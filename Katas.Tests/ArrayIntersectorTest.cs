using NUnit.Framework;

namespace Katas.Tests
{
    [TestFixture]
    public class ArrayIntersectorTest
    {
        [Test]
        public void Intersect__returns_correct_result()
        {
            var a = new[] {"dog", "bar", "foo"};
            var b = new[] {"foo", "bar", "cat"};
            var c = new[] {"gin", "foo", "bar"};

            Assert.AreEqual(new[] {"bar", "foo"}, ArrayIntersector.Intersect(a, b, c));
        }

        [Test]
        public void Intersect__handles_empty_input()
        {
            Assert.AreEqual(new string[] { }, ArrayIntersector.Intersect(new string[][] { }));
        }
    }
}
