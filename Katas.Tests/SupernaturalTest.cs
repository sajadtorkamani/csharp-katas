using NUnit.Framework;

namespace Katas.Tests
{
    [TestFixture]
    class SupernaturalTest
    {
        [Test]
        public void Bob_ReturnsCorrectKillingTechniqueBaseOnEnemyType()
        {
            Assert.AreEqual("Behead it with a machete, idjits!", Supernatural.Bob("vampire"));
            Assert.AreEqual("It depends on which one it is, idjits!", Supernatural.Bob("pagan god"));
        }

        [Test]
        public void Bob_HandlesUnknownEnemyTypes()
        {
            Assert.AreEqual("I have friggin no idea yet, idjits!", Supernatural.Bob("werepuppy"));
        }
    }
}
