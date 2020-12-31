using System.Linq;
using System.Text.RegularExpressions;

namespace Katas
{
    public class LikesCounter
    {
        public static bool EvalLikes(string[] words)
        {
            if (words.Length == 0)
            {
                return false;
            }

            var regex = new Regex("^like$", RegexOptions.IgnoreCase);
            float numLikes = words.Count(word => regex.IsMatch(word));

            return numLikes / words.Length > 0.05;
        }
    }
}
