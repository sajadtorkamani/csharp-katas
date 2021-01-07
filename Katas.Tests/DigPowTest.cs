using NUnit.Framework;

namespace Katas.Tests
{
    [TestFixture]
    public class DigPowTest
    {
        [Test]
        public void digPow__returns_correct_result()
        {
            Assert.AreEqual(1, DigPow.digPow(89, 1));
            Assert.AreEqual(-1, DigPow.digPow(92, 1));
            Assert.AreEqual(51, DigPow.digPow(46288, 3));
        }
    }
}
