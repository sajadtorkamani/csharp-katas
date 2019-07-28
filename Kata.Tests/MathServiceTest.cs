using NUnit.Framework;
using Katas;

namespace KataTests
{
    public class MathService_AddShould
    {
        [Test]
        public void AddTwoArgs()
        {
            Assert.AreEqual(5, MathService.Add(2, 3));
        }
    }
}
