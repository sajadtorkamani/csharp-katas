using NUnit.Framework;

public class LikesCounter_EvalLikesShould
{
    [Test]
    public void ReturnCorrectResult()
    {
        Assert.AreEqual(true, LikesCounter.EvalLikes(new string[] {"today", "was", "so", "like", "awesome"}));

        Assert.AreEqual(false, LikesCounter.EvalLikes(new string[] {}));
        Assert.AreEqual(false, LikesCounter.EvalLikes(new string[] {"yesterday", "was", "even", "likely", "better"}));
    }
}