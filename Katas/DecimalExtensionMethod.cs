// https://www.codewars.com/kata/format-number-as-currency-using-extension-method/train/csharp

using System;

namespace Katas
{
    public static class DecimalExtensionMethod
    {
        public static string ToCurrency(this Decimal val, string prefix)
        {
            var amount = $"{Math.Abs(val):0.00}";

            return val >= 0 ? $"{prefix}{amount}" : $"-{prefix}{amount}";
        }
    }
}
