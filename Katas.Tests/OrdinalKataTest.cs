using NUnit.Framework;

namespace Katas.Tests
{
    [TestFixture]
    public class OrdinalKataTest
    {
        [Test]
        public void Ordinal__handles_simple_cases()
        {
            Assert.AreEqual("th", OrdinalKata.Ordinal(0));
            Assert.AreEqual("st", OrdinalKata.Ordinal(1));
            Assert.AreEqual("nd", OrdinalKata.Ordinal(2));
            Assert.AreEqual("rd", OrdinalKata.Ordinal(3));
            Assert.AreEqual("th", OrdinalKata.Ordinal(4));
            Assert.AreEqual("st", OrdinalKata.Ordinal(121));
            Assert.AreEqual("th", OrdinalKata.Ordinal(20));
            Assert.AreEqual("nd", OrdinalKata.Ordinal(52));
        }

        [Test]
        public void Ordinal__handles_edge_cases()
        {
            Assert.AreEqual("th", OrdinalKata.Ordinal(11));
            Assert.AreEqual("th", OrdinalKata.Ordinal(111));
        }

        [Test]
        public void Ordinal__handles_brief_option()
        {
            Assert.AreEqual("d", OrdinalKata.Ordinal(903, true));
        }
    }
}