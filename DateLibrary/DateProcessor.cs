using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateLibrary;

public class DateProcessor
{
    private readonly List<string> _storedDates = new List<string>();

    public void AddDate(string date)
    {
        if (DateValidator.IsValidDateString(date))
            _storedDates.Add(date);
    }

    public void ProcessAllDates()
    {
        foreach (var date in _storedDates)
        {
            if (DateValidator.IsValidDateString(date))
            {
                DateTime parsedDate = DateParser.ParseDate(date);
                string dayOfWeek = DateFormatter.GetDayOfWeekInRussian(parsedDate);
                Console.WriteLine($"{date} - {dayOfWeek}");
            }
        }
    }

    public void DisplayDateOperations(string firstDateString, string secondDateString, int daysToAdd)
    {
        if (!DateValidator.IsValidDateString(firstDateString) ||
            !DateValidator.IsValidDateString(secondDateString))
        {
            Console.WriteLine("One or both dates are invalid");
            return;
        }

        DateTime firstDate = DateParser.ParseDate(firstDateString);
        DateTime secondDate = DateParser.ParseDate(secondDateString);

        string convertedDate = DateFormatter.ConvertDateFormat(firstDateString, DateConstants.FormatMMDDYYYY);
        string dayOfWeek = DateFormatter.GetDayOfWeekInRussian(firstDate);
        int daysDifference = DateCalculator.GetDaysDifference(firstDate, secondDate);
        DateTime newDate = DateCalculator.AddDays(firstDate, daysToAdd);
        bool isLeapYear = DateValidator.IsLeapYear(firstDate.Year);

        Console.WriteLine($"Конвертированная дата: {convertedDate}");
        Console.WriteLine($"День недели: {dayOfWeek}");
        Console.WriteLine($"Разница в днях: {daysDifference}");
        Console.WriteLine($"Дата после добавления {daysToAdd} дней: {newDate:dd/MM/yyyy}");
        Console.WriteLine($"Високосный год: {isLeapYear}");
    }
}
