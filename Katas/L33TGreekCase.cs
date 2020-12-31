// https://www.codewars.com/kata/l33t-plus-greek-case/train/csharp

using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class L33TGreekCase
    {
        private static readonly Dictionary<char, char> Chars = new Dictionary<char, char>()
        {
            {'a', 'α'}, {'b', 'β'}, {'d', 'δ'}, {'e', 'ε'}, {'i', 'ι'}, {'k', 'κ'},
            {'n', 'η'}, {'o', 'θ'}, {'p', 'ρ'}, {'r', 'π'}, {'t', 'τ'}, {'u', 'μ'},
            {'v', 'υ'}, {'w', 'ω'}, {'x', 'χ'}, {'y', 'γ'}
        };

        public static string GreekL33t(string str)
        {
            var letters = str
                .ToLower()
                .ToCharArray()
                .Select(letter => Chars.ContainsKey(letter) ? Chars[letter] : letter);

            return string.Join(string.Empty, letters);
        }
    }
}
