using System;
using System.Collections;
class Program
{
  static void Main(string[] args)
  {
     

     string dt = "2010-10-04T20:12:45-5:00";
     DateTime newDt = DateTime.Parse(dt);
     Console.WriteLine(newDt.ToString());  

     DateTime dob = new DateTime(2002, 10, 22);
     Console.WriteLine(DateTime.IsLeapYear(dob.Year));

     DateTime firstDate = new DateTime(2002, 10, 22);
     DateTime secondDate = new DateTime(2009, 8, 11);
     int result = DateTime.Compare(firstDate, secondDate);
    if (result < 0)
       Console.WriteLine("First date is earlier");
    else if (result == 0)
       Console.WriteLine("Both dates are same");
    else
    Console.WriteLine("First date is later");

    int days = DateTime.DaysInMonth(2002, 2);
Console.WriteLine(days);

DateTime dob2 = new DateTime(2000, 10, 20, 12, 15, 45);
DateTime subDate = new DateTime(2000, 2, 6, 13, 5, 15);

// TimeSpan with 10 days, 2 hrs, 30 mins, 45 seconds, and 100 milliseconds
TimeSpan ts = new TimeSpan(10, 2, 30, 45, 100);

// Subtract a DateTime
TimeSpan diff1 = dob2.Subtract(subDate);
Console.WriteLine(diff1.ToString());

// Subtract a TimeSpan
DateTime diff2 = dob2.Subtract(ts);
Console.WriteLine(diff2.ToString());

DateTime dob3 = new DateTime(1974, 7, 10, 7, 10, 24);
Console.WriteLine("Day:{0}", dob3.Day);
Console.WriteLine("Month:{0}", dob3.Month);
Console.WriteLine("Year:{0}", dob3.Year);
Console.WriteLine("Hour:{0}", dob3.Hour);
Console.WriteLine("Minute:{0}", dob3.Minute);
Console.WriteLine("Second:{0}", dob3.Second);
  }
}