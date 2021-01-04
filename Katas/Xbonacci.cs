// https://www.codewars.com/kata/tribonacci-sequence/train/csharp
using System.Linq;

namespace Katas
{
    public class Xbonacci
    {
        public double[] Tribonacci(double[] signature, int n)
        {
            var sequence = signature.ToList();

            if (n <= 3)
            {
                return sequence.GetRange(0, n).ToArray();
            }

            for (var index = 3; index < n; index++)
            {
                sequence.Add(sequence.GetRange(index - 3, 3).Sum());
            }

            return sequence.ToArray();
        }
    }
}
