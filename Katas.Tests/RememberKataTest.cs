using NUnit.Framework;
using System.Collections.Generic;

namespace Katas.Tests
{
    /*
     * Split into char array ['a', 'p', 'p', 'l', 'e']
     * Filter only unique chars ['a', 'p', 'l', 'e']
     * Filter only chars that appear more than once ['p']
     * Sort chars
     * Return chars
    */
    [TestFixture]
    public class RememberKataTest
    {
        [Test]
        public void Remember__returns_correct_result()
        {
            Assert.AreEqual(new List<char> {'p'}, RememberKata.Remember("apple"));
            Assert.AreEqual(new List<char>(), RememberKata.Remember("apPle"));
            Assert.AreEqual(new List<char> {'p', 'i'}, RememberKata.Remember("pippi"));
            Assert.AreEqual(new List<char> {'p', 'i'}, RememberKata.Remember("Pippi"));
        }
    }
}