using NUnit.Framework;

namespace Katas.Tests
{
    [TestFixture]
    public class GetInitialsTest
    {
        [Test]
        /**
         * Split into words array
         * Map over each word in array and return first char with a period
         * Join initials with a space
         */
        public void ToInitials__returns_correct_result()
        {
            Assert.AreEqual("K. K.", GetInitials.ToInitials("Kerry King"));
            Assert.AreEqual("T. A.", GetInitials.ToInitials("Tom Araya"));
        }
    }
}