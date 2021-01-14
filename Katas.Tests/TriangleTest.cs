using NUnit.Framework;

namespace Katas.Tests
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        public void IsTriangle__returns_correct_result()
        {
            Assert.IsTrue(Triangle.IsTriangle(5, 7, 10));
        }
    }
}
