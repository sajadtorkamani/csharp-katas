// https://www.codewars.com/kata/is-this-a-triangle/train/csharp
namespace Katas
{
    public class Triangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            return ((a + b) > c) && ((a + c) > b) && ((b + c) > a);
        }
    }
}