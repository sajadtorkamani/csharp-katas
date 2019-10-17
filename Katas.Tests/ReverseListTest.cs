using NUnit.Framework;

namespace Katas.Tests
{
    [TestFixture]
    public class ReverseListTes
    {
        [Test]
        public void reverseList_returnsCorrectResult()
        {
            Assert.AreEqual(new int[0], ReverseList.reverseList(new int[0]));
            Assert.AreEqual(new int[] {3, 2, 1}, ReverseList.reverseList(new int[] {1, 2, 3}));
        }
    }
}