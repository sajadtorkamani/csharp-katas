// https://www.codewars.com/kata/normalizing-out-of-range-array-indexes/train/csharp

using System;

namespace Katas
{
    public class IndexNormalizer
    {
        public static int NormIndex(int[] arr, int index)
        {
            var length = arr.Length;

            if (index >= 0)
            {
                return arr[index % length];
            }

            return Math.Abs(index) > length
                ? NormIndex(arr, length + index) // Handle out-of-range-range negative indices
                : arr[length + index];
        }
    }
}
