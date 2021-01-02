// https://www.codewars.com/kata/temperature-analysis-i/train/csharp

using System;
using System.Linq;

namespace Katas
{
    public class TemperatureAnalysis
    {
        public static int? LowestTemperature(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }

            return str
                .Split(" ")
                .Select(t => Convert.ToInt32(t))
                .Min();
        }
    }
}
