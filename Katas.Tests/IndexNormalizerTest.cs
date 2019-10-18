using NUnit.Framework;

namespace Katas.Tests
{
    [TestFixture]
    public class IndexNormalizerTest
    {
        [Test]
        public void NormIndex__handles_in_range_indices()
        {
            var arr = new int[] {2, 4, 6, 8, 10};

            Assert.AreEqual(4, IndexNormalizer.NormIndex(arr, 1));
            Assert.AreEqual(6, IndexNormalizer.NormIndex(arr, 2));

        }

        [Test]
        public void NormIndex__handles_positive_out_of_range_indices()
        {
            var arr = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            Assert.AreEqual(1, IndexNormalizer.NormIndex(arr, 11));
        }

        [Test]
        public void NormIndex__handles_negative_indices()
        {
            var arr = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            Assert.AreEqual(9, IndexNormalizer.NormIndex(arr, -1));
            Assert.AreEqual(7, IndexNormalizer.NormIndex(arr, -3));
        }

        [Test]
        public void NormIndex__handles_negative_out_of_range_indices()
        {
            var arr = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

            Assert.AreEqual(0, IndexNormalizer.NormIndex(arr, -10));
            Assert.AreEqual(9, IndexNormalizer.NormIndex(arr, -11));
        }
    }
}