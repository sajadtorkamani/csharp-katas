using System;
using NUnit.Framework;

[TestFixture]
public class BookTests_DayIsShould
{ 
  [Test]
  public void HandleSimpleCase()
  {
    int[] days = new int[] { 15, 20, 20, 15, 10, 30, 45 };
    int pages = 100;
    Assert.AreEqual(6, Book.DayIs(pages, days));
  }

  [Test]
  public void HandleComplexCase()
  {
    int[] days = new int[] {1,0,0,0,0,0,0 };
    int pages = 2;
    Assert.AreEqual(1, Book.DayIs(pages, days));
  }
}