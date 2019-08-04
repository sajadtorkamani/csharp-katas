using System;
 
public class Book
{
  public static int DayIs(int totalPages, int[] days)
  {
    int currentDay = 0;         
    int numPagesRead = 0;
    
    while (true) {
      numPagesRead += days[currentDay];    
      
      if (numPagesRead >= totalPages) {
        return currentDay + 1;
      }
      
      currentDay = (currentDay == days.Length - 1) ? 0 : currentDay + 1;
    }
  }
}