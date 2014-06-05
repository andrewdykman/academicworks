// Lab 7.1 by Andrew Dykman, Intro to Java
// MyCalander, a Subclass of Gregorian Calander

// Begin Code

// Call APIs

import java.awt.*;
import java.util.*;

public class MyCalendar extends GregorianCalendar {
  public int daysInMonth() {
    switch (get(MONTH)) {
      case 0: case 2: case 4: case 6: case 7: case 9: case 11:
        return 31;
      case 1: if (isLeapYear(get(YEAR))) return 29;
                else return 28;
      case 3: case 5: case 8: case 10: return 30;
      default: return 0;
    }
  }
  
  public String getMonthName() {
    String monthName = null;

    switch (get(MONTH)) {
      case 0: monthName = "January"; break;
      case 1: monthName = "Feburary";	break;
      case 2: monthName = "March"; break;
      case 3: monthName = "April"; break;
      case 4: monthName = "May"; break;
      case 5: monthName = "June"; break;
      case 6: monthName = "July"; break;
      case 7: monthName = "August"; break;
      case 8: monthName = "September"; break;
      case 9: monthName = "October"; break;
      case 10: monthName = "November"; break;
      case 11: monthName = "December"; break;
      default:
    }

    return monthName;
  }
}

// End Code. Huzzah!