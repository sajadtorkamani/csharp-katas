using System.Linq;

namespace Katas
{
    public class ReverseList
    {
        public static int[] reverseList(int[] list)
        {
            return list.Reverse().ToArray();
        }
    }
}
