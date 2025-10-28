using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateLibrary;

public static class DateValidator
{
    public static bool IsValidDate(int year, int month, int day)
    {
        if (year < DateConstants.MinYear || year > DateConstants.MaxYear)
            return false;

        if (month < DateConstants.MinMonth || month > DateConstants.MaxMonth)
            return false;

        if (day < DateConstants.MinDay)
            return false;

        return day <= DateTime.DaysInMonth(year, month);
    }

    public static bool IsValidDateString(string dateString)
    {
        if (string.IsNullOrWhiteSpace(dateString))
            return false;

        string[] dateParts = dateString.Split(DateConstants.DateSeparator);

        if (dateParts.Length != DateConstants.ExpectedDatePartsCount)
            return false;

        try
        {
            int day = int.Parse(dateParts[0]);
            int month = int.Parse(dateParts[1]);
            int year = int.Parse(dateParts[2]);

            return IsValidDate(year, month, day);
        }
        catch
        {
            return false;
        }
    }

    public static bool IsLeapYear(int year)
    {
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}
