// https://www.codewars.com/kata/friday-the-13ths/train/csharp

using System;
using System.Collections.Generic;

namespace Katas
{
    public class FridayTheThirteenthsKata
    {
        public static string FridayTheThirteenths(int year)
        {
            return FridayTheThirteenths(year, year);
        }

        public static string FridayTheThirteenths(int startYear, int? endYear)
        {
            if (endYear == null)
            {
                endYear = startYear;
            }

            var thirteenths = new List<string>();

            for (var year = startYear; year <= endYear; year++)
            {
                for (var month = 1; month <= 12; month++)
                {
                    var date = new DateTime(year, month, 13);

                    if (date.DayOfWeek.Equals(DayOfWeek.Friday))
                    {
                        thirteenths.Add($"{date:M/dd/yyyy}");
                    }
                }
            }

            return string.Join(" ", thirteenths);
        }
    }
}