using NUnit.Framework;

namespace Katas.Tests
{
    /**
     * Split into array of number strings.
     * Map over each item and convert to int.
     * Return lowest one.
     */
    [TestFixture]
    public class TemperatureAnalysisTest
    {
        [Test]
        public void LowestTemperature__returns_lowest_temperature_from_string()
        {
            Assert.AreEqual(-8, TemperatureAnalysis.LowestTemperature("-1 50 -4 20 22 -7 0 10 -8"));
            Assert.AreEqual(10, TemperatureAnalysis.LowestTemperature("10 50 12 20 22 13 20 100 18"));
            Assert.AreEqual(-1, TemperatureAnalysis.LowestTemperature("-1 50 16 20 22 1 0 10 34"));
            Assert.AreEqual(-2, TemperatureAnalysis.LowestTemperature("-2 3 -1 12 45 14"));
        }

        [Test]
        public void LowestTemperature__returns_null_when_empty_string()
        {
            Assert.AreEqual(null, TemperatureAnalysis.LowestTemperature(""));
        }
    }
}