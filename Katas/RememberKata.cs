// https://www.codewars.com/kata/remember/train/csharp
// This doesn't pass the actual final kata tests but I'm not sure why...

using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class RememberKata
    {
        public static List<char> Remember(string str)
        {
            var repeatedChars = str
                .ToCharArray()
                .Distinct()
                .Where(letter => str.Count(c => c == letter) > 1)
                .ToList();

            repeatedChars.Sort(new RepetitionOrderComparer(str));

            return repeatedChars;
        }
    }

    public class RepetitionOrderComparer : IComparer<char>
    {
        private readonly string _str;

        public RepetitionOrderComparer(string str)
        {
            _str = str;
        }

        public int Compare(char a, char b)
        {
            var aRepetitionIndex = _str.IndexOf($"{a}{a}");
            var bRepetitionIndex = _str.IndexOf($"{b}{b}");

            return bRepetitionIndex.CompareTo(aRepetitionIndex);
        }
    }
}