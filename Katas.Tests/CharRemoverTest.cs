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

//            Assert.AreEqual("pples d bnns",
//                CharRemover.Remove("apples and bananas", new Dictionary<char, int> {{'a', 50}, {'n', 1}}));
//            Assert.AreEqual("", CharRemover.Remove("a", new Dictionary<char, int> {{'a', 1}, {'n', 1}}));
//            Assert.AreEqual("",
//                CharRemover.Remove("codewars",
//                    new Dictionary<char, int>
//                        {{'c', 5}, {'o', 1}, {'d', 1}, {'e', 1}, {'w', 1}, {'z', 1}, {'a', 1}, {'r', 1}, {'s', 1}}));
        }
    }

    /**
     * Iterate over each item in dictionary
     *     Remove n occurrences of char from string
     * Return modified string
     */
}