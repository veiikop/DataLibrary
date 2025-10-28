using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateLibrary;

public static class DateCalculator
{
    public static int GetDaysDifference(DateTime firstDate, DateTime secondDate)
    {
        TimeSpan difference = firstDate - secondDate;
        return Math.Abs(difference.Days);
    }

    public static DateTime AddDays(DateTime date, int daysToAdd)
    {
        return date.AddDays(daysToAdd);
    }

    public static DateTime SubtractDays(DateTime date, int daysToSubtract)
    {
        return date.AddDays(-daysToSubtract);
    }
}
