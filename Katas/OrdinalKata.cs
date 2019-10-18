// https://www.codewars.com/kata/ordinal-numbers/train/csharp

using System.Linq;
using System.Text.RegularExpressions;

namespace Katas
{
    public class OrdinalKata
    {
        public static string Ordinal(int number, bool useBrief = false)
        {
            var num = number.ToString();

            // Handle special case
            if (Regex.IsMatch(num, @"1[123]$"))
            {
                return "th";
            }

            switch (num.Last())
            {
                case '1': return "st";
                case '2': return useBrief ? "d" : "nd";
                case '3': return useBrief ? "d" : "rd";
                default: return "th";
            }
        }
    }
}