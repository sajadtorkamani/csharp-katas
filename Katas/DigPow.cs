// https://www.codewars.com/kata/playing-with-digits/train/csharp
using System;
using System.Linq;

namespace Katas
{
    public class DigPow
    {
        public static long digPow(int n, int p)
        {
            var digitsSum = n
                .ToString()
                .Select((digitAsChar, index) =>
                {
                    var digit = Convert.ToInt32(digitAsChar.ToString());
                    return Math.Pow(digit, index + p);
                })
                .Sum();

            var result = digitsSum / n;
            var isValidResult = result % 1 == 0;

            return (long) (isValidResult ? result : -1);
        }
    }
}
