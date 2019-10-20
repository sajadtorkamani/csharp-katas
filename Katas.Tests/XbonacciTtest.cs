using NUnit.Framework;

namespace Katas.Tests
{
    /**
     * Create initial list populated with signature elements [1, 1, 1]
     * Iterate (n - 3) times, staring at index 3
     *    Add the sum of the last three digits
     */
    [TestFixture]
    public class XbonacciTest
    {
        private Xbonacci _xbonacci;

        [SetUp]
        public void SetUp()
        {
            _xbonacci = new Xbonacci();
        }

        [Test]
        public void Tribonacci__returns_correct_result()
        {
            Assert.AreEqual(
                new double[] {1, 1, 1, 3, 5, 9, 17, 31, 57, 105},
                _xbonacci.Tribonacci(new double[] {1, 1, 1}, 10)
            );
            Assert.AreEqual(
                new double[] {0, 0, 1, 1, 2, 4, 7, 13, 24, 44},
                _xbonacci.Tribonacci(new double[] {0, 0, 1}, 10)
            );
            Assert.AreEqual(
                new double[] {0, 1, 1, 2, 4, 7, 13, 24, 44, 81},
                _xbonacci.Tribonacci(new double[] {0, 1, 1}, 10)
            );
        }

        [Test]
        public void Tribonacci__handles_edge_cases()
        {
            Assert.AreEqual(
                new double[] { },
                _xbonacci.Tribonacci(new double[] {1, 1, 1}, 0)
            );

            Assert.AreEqual(
                new double[] {1},
                _xbonacci.Tribonacci(new double[] {1, 1, 1}, 1)
            );
        }
    }
}