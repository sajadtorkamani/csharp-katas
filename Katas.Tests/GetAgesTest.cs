using Katas;
using NUnit.Framework;

namespace Kata.Tests
{
    [TestFixture]
    public class GetAgesTest
    {
        [Test]
        public void Calculate__returns_correct_result()
        {
            Assert.AreEqual(new double[] {14, 10}, GetAges.Calculate(24, 4));
            Assert.AreEqual(new double[] {38.5, 24.5}, GetAges.Calculate(63, 14));
        }

        [Test]
        public void Calculate__returns_null_when_sum_is_negative()
        {
            Assert.AreEqual(null, GetAges.Calculate(-5, 10));
        }

        [Test]
        public void Calculate__returns_null_when_difference_is_negative()
        {
            Assert.AreEqual(null, GetAges.Calculate(5, -10));
        }
        
        [Test]
        public void Calculate__returns_null_when_any_age_is_negative()
        {
            Assert.AreEqual(null, GetAges.Calculate(5, -10));
        }
    }
}