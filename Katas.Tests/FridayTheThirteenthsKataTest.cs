using NUnit.Framework;

namespace Katas.Tests
{
    [TestFixture]
    public class FridayTheThirteenthsKataTest
    {
        [Test]
        public void FridayTheThirteenths__returns_correct_result()
        {
            Assert.AreEqual(
                "8/13/1999 10/13/2000",
                FridayTheThirteenthsKata.FridayTheThirteenths(1999, 2000)
            );

            Assert.AreEqual(
                "6/13/2014 2/13/2015 3/13/2015 11/13/2015",
                FridayTheThirteenthsKata.FridayTheThirteenths(2014, 2015)
            );

            Assert.AreEqual("10/13/2000", FridayTheThirteenthsKata.FridayTheThirteenths(2000));
        }
    }
}

/**
 * Create fridayTheThirteenths list
 * Iterate from start year to end year (inclusive)
 *     Check if the 13th of each month is a Friday - if so, add to list
 *  Return formatted list
 */