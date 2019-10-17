using NUnit.Framework;

namespace Katas.Tests
{
    public class AddColorsTest
    {
        [Test]
        public void AdditiveColors__returns_correct_result()
        {
            Assert.AreEqual("White", AddColors.AdditiveColors("Red,Green,Blue"));
            Assert.AreEqual("Yellow", AddColors.AdditiveColors("Red,Green"));
            Assert.AreEqual("Magenta", AddColors.AdditiveColors("Red, Blue"));
            Assert.AreEqual("Cyan", AddColors.AdditiveColors("Blue,Green"));
            Assert.AreEqual("Green", AddColors.AdditiveColors("Green"));
        }
    }
}