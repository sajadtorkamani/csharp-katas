using NUnit.Framework;

namespace Katas.Tests
{
    /*
     * Convert to lowercase
     * Split into char array
     * Map over each char
     *     Return Greek replacement
     * Return joined char array
     */
    [TestFixture]
    public class GreekLeetTest
    {
        [Test]
        public void GreekL33T__returns_correct_result()
        {
            Assert.AreEqual("cθδεωαπs", L33TGreekCase.GreekL33t("CodeWars"));
            Assert.AreEqual("κατα", L33TGreekCase.GreekL33t("kata"));
            Assert.AreEqual("κμmιτε", L33TGreekCase.GreekL33t("kumite"));
            Assert.AreEqual("gπεεκlεετ", L33TGreekCase.GreekL33t("greekleet"));
        }
    }
}