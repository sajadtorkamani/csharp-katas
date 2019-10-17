using NUnit.Framework;

namespace Katas.Tests
{
    public class LikesCounterTest
    {
        [Test]
        public void EvalLikes__returns_correct_result()
        {
            Assert.AreEqual(true, LikesCounter.EvalLikes(new string[] {"today", "was", "so", "like", "awesome"}));

            Assert.AreEqual(false, LikesCounter.EvalLikes(new string[] { }));
            Assert.AreEqual(false,
                LikesCounter.EvalLikes(new string[] {"yesterday", "was", "even", "likely", "better"}));
        }
    }
}