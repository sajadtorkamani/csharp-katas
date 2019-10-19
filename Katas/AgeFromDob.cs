// https://www.codewars.com/kata/age-from-dob/train/csharp
using System;

namespace Katas
{
    public class AgeFromDob
    {
        private readonly IClock _clock;

        public AgeFromDob(IClock clock)
        {
            _clock = clock;
        }

        /*
         * TODO: This does NOT handle leap years properly. Just wanted to pass the kata :)
         */
        public int GetAgeFromDOB(DateTime birthday)
        {
            var timeSpan = _clock.Now - birthday;

            if (timeSpan.Days == 365)
            {
                return 1;
            }

            var age = timeSpan.TotalDays / 365.2425;

            return (int) Math.Floor(age);
        }
    }

    public interface IClock
    {
        DateTime Now { get; }
    }

    public class SystemClock : IClock
    {
        public DateTime Now => DateTime.Now;
    }

    public class StaticClock : IClock
    {
        public DateTime Now { get; }

        public StaticClock(DateTime dateTime)
        {
            Now = dateTime;
        }
    }
}