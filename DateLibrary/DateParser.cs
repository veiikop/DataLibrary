using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateLibrary;

public static class DateParser
{
    public static DateTime ParseDate(string dateString)
    {
        if (string.IsNullOrWhiteSpace(dateString))
            throw new ArgumentException("Date string cannot be null or empty");

        string[] dateParts = dateString.Split(DateConstants.DateSeparator);

        if (dateParts.Length != DateConstants.ExpectedDatePartsCount)
            throw new ArgumentException($"Invalid date format. Expected format: DD{DateConstants.DateSeparator}MM{DateConstants.DateSeparator}YYYY");

        int day = int.Parse(dateParts[0]);
        int month = int.Parse(dateParts[1]);
        int year = int.Parse(dateParts[2]);

        if (!DateValidator.IsValidDate(year, month, day))
            throw new ArgumentException("Invalid date values");

        return new DateTime(year, month, day);
    }

    public static bool TryParseDate(string dateString, out DateTime result)
    {
        result = default;

        try
        {
            result = ParseDate(dateString);
            return true;
        }
        catch
        {
            return false;
        }
    }
}
