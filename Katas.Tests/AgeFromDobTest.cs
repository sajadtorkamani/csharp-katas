using System;
using NUnit.Framework;

namespace Katas.Tests
{
    [TestFixture]
    public class AgeFromDobTest
    {
        [Test]
        public void SystemClock__returns_current_time()
        {
            Assert.AreEqual(DateTime.Now.Year, new SystemClock().Now.Year);
            Assert.AreEqual(DateTime.Now.Month, new SystemClock().Now.Month);
            Assert.AreEqual(DateTime.Now.Day, new SystemClock().Now.Day);
        }

        [Test]
        public void StaticClock__returns_constructor_input()
        {
            Assert.AreEqual(
                new DateTime(1993, 12, 7),
                new StaticClock(new DateTime(1993, 12, 7)).Now
            );
        }

        [Test]
        public void AgeFromDob_GetAgeFromDOB__returns_correct_result()
        {
            var clock = new StaticClock(new DateTime(2008, 09, 3));
            var birthday = new DateTime(1984, 04, 23);

            Assert.AreEqual(24, new AgeFromDob(clock).GetAgeFromDOB(birthday));
        }

        [Test]
        public void AgeFromDob_GetAgeFromDOB__handles_leap_years()
        {
            var clock = new StaticClock(new DateTime(2005, 03, 31));
            var birthday = new DateTime(2003, 04, 01);

            Assert.AreEqual(1, new AgeFromDob(clock).GetAgeFromDOB(birthday));
        }

        [Test]
        public void AgeFromDob_GetAgeFromDOB__handles_leap_years_2()
        {
            var clock = new StaticClock(new DateTime(2003, 01, 01));
            var birthday = new DateTime(2002, 01, 01);

            Assert.AreEqual(1, new AgeFromDob(clock).GetAgeFromDOB(birthday));
        }
    }
}