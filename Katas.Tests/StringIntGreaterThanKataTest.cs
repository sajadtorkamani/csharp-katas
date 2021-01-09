using NUnit.Framework;

namespace Katas.Tests
{
    [TestFixture]
    public class StringIntGreaterThanKataTest
    {
        [Test]
        public void StringIntGreaterThan__returns_correct_result()
        {
            Assert.IsTrue(StringIntGreaterThanKata.StringIntGreaterThan("162", "54"));
            Assert.IsFalse(StringIntGreaterThanKata.StringIntGreaterThan("31", "162"));
            Assert.IsFalse(StringIntGreaterThanKata.StringIntGreaterThan("16", "162"));
        }
    }
}
