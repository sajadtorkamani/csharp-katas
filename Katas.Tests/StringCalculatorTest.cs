using NUnit.Framework;

namespace Katas.Tests
{
    [TestFixture]
    class StringCalculatorTest
    {
        [Test]
        public void AddStrings_ReturnsSumOfNumsInString()
        {
            Assert.AreEqual(5, StringCalculator.AddStrings("2, 3"));
            Assert.AreEqual(60, StringCalculator.AddStrings("20, 20, 20"));
        }
    }
}
