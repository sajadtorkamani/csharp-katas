// https://www.codewars.com/kata/replaceall-input-find-replace/train/csharp

using System.Text.RegularExpressions;

namespace Katas
{
    public class ReplaceAll
    {
        public static string Replace(string input, string pattern, string replacement)
        {
            return Regex.Replace(input, Regex.Escape(pattern), replacement);
        }
    }
}