
using System;
using System.Linq;

namespace Katas
{
    public class StringCalculator
    {
        public static int AddStrings(string expression)
        {
            var sum = expression.Split(", ").Select(Int32.Parse).Sum();

            return sum;
        }
    }
}
