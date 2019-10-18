using NUnit.Framework;

namespace Katas.Tests
{
    [TestFixture]
    public class ReplaceAllTest
    {
        [Test]
        public void Replace__returns_correct_result()
        {
            Assert.AreEqual("str!-str!", ReplaceAll.Replace("string-string", "ing", "!"));
        }

        [Test]
        public void Replace__handles_empty_find_arg()
        {
            Assert.AreEqual("-1-2-3-", ReplaceAll.Replace("123", "", "-"));
            Assert.AreEqual("-1-", ReplaceAll.Replace("1", "", "-"));
            Assert.AreEqual("-", ReplaceAll.Replace("", "", "-"));
        }
    }
}
