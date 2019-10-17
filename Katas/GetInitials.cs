// https://www.codewars.com/kata/get-initials-from-person-name/train/csharp

using System.Linq;

namespace Katas
{
    public class GetInitials
    {
        public static string ToInitials(string name)
        {
            var initials = name.Split(" ").Select(word => word[0] + ".");

            return string.Join(" ", initials);
        }
    }
}