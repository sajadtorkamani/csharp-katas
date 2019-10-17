// https://www.codewars.com/kata/not-all-but-sometimes-all/train/csharp

using System.Collections.Generic;

namespace Katas
{
    public class CharRemover
    {
        // TODO: should use a more concise regex solution.
        public static string Remove(string str, Dictionary<char, int> dict)
        {
            foreach (var item in dict)
            {
                var letter = item.Key;
                var removeCount = item.Value;

                for (var i = 0; i < removeCount; i++)
                {
                    var letterIndex = str.IndexOf(letter);

                    // Remove letter, if found
                    if (letterIndex >= 0)
                    {
                        str = str.Remove(letterIndex, 1);
                    }
                    // Continue to next letter if letter not found
                    else
                    {
                        break;
                    }
                }
            }

            return str;
        }
    }
}