//You are assigned to find and fix all bugs in the existing code.
//By using the Visual Studio debugger, place a breakpoint and find the lines of code that produce incorrect or unexpected results.
//You are given a program (existing source code) that aims to count the non-working days between two dates in format day.month.year
//(e.g. between 1.05.2015 and 15.05.2015 there are 5 non-working days – Saturday and Sunday).

using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        var startDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);
        var endDate = DateTime.ParseExact(Console.ReadLine(),
            "d.M.yyyy", CultureInfo.InvariantCulture);
        var holidaysCount = 0;
        for (var date = startDate; date <= endDate; date = date.AddDays(1))
            if (date.DayOfWeek == DayOfWeek.Saturday ||
                date.DayOfWeek == DayOfWeek.Sunday) holidaysCount++;
        Console.WriteLine(holidaysCount);
    }
}