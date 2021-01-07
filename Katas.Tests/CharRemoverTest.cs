using System.Collections.Generic;
using Katas;
using NUnit.Framework;

namespace Kata.Tests
{
    [TestFixture]
    public class CharRemoverTest
    {
        [Test]
        public void Remove__returns_correct_result()
        {
            Assert.AreEqual(
                "hs s a string",
                CharRemover.Remove("this is a string", new Dictionary<char, int> {{'t', 1}, {'i', 2}})
            );

            Assert.AreEqual(
                "hello world",
                CharRemover.Remove("hello world", new Dictionary<char, int> {{'x', 5}, {'i', 2}})
            );
        }
    }
}