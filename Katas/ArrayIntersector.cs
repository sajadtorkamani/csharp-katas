using System.Linq;

namespace Katas
{
    public static class ArrayIntersector
    {
        public static string[] Intersect(params string[][] arrays)
        {
            if (arrays.Length == 0)
            {
                return new string[] { };
            }

            return arrays
                .Aggregate((a, b) => a.Intersect(b).ToArray())
                .Where(item => arrays.All(arr => arr.Contains(item)))
                .ToArray();
        }
    }
}