using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateLibrary;

public static class DateFormatter
{
    public static string ConvertDateFormat(string inputDate, int formatType)
    {
        if (!DateValidator.IsValidDateString(inputDate))
            return inputDate;

        string[] dateParts = inputDate.Split(DateConstants.DateSeparator);

        return formatType switch
        {
            DateConstants.FormatDDMMYYYY => $"{dateParts[0]}{DateConstants.DateSeparator}{dateParts[1]}{DateConstants.DateSeparator}{dateParts[2]}",
            DateConstants.FormatMMDDYYYY => $"{dateParts[1]}{DateConstants.DateSeparator}{dateParts[0]}{DateConstants.DateSeparator}{dateParts[2]}",
            _ => inputDate
        };
    }

    public static string GetDayOfWeekInRussian(DateTime date)
    {
        return date.DayOfWeek switch
        {
            DayOfWeek.Monday => "Понедельник",
            DayOfWeek.Tuesday => "Вторник",
            DayOfWeek.Wednesday => "Среда",
            DayOfWeek.Thursday => "Четверг",
            DayOfWeek.Friday => "Пятница",
            DayOfWeek.Saturday => "Суббота",
            DayOfWeek.Sunday => "Воскресенье",
            _ => "Неизвестно"
        };
    }
}
