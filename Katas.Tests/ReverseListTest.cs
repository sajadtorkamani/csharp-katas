using NUnit.Framework;

namespace Katas.Tests
{
    [TestFixture]
    public class ReverseListTest
    {
        [Test]
        public void ReverseList__reverses_given_list()
        {
            Assert.AreEqual(new int[0], ReverseList.reverseList(new int[0]));
            Assert.AreEqual(new int[] {3, 2, 1}, ReverseList.reverseList(new int[] {1, 2, 3}));
        }
    }
}
