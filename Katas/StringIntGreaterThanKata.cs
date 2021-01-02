// https://www.codewars.com/kata/string-integer-greater-than/train/csharp
using System.Numerics;

namespace Katas
 {
     public class StringIntGreaterThanKata
     {
         public static bool StringIntGreaterThan(string a, string b)
         {
             return BigInteger.Parse(a) > BigInteger.Parse(b);
         }
     }
 }
 