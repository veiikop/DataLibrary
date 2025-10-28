namespace DateLibrary;

class Program
{
    static void Main(string[] args)
    {
        DateProcessor processor = new DateProcessor();

        // Добавляем тестовые даты
        processor.AddDate("25/12/2023");
        processor.AddDate("01/01/2024");
        processor.AddDate("29/02/2024");
        processor.AddDate("invalid_date"); // Эта дата не добавится

        Console.WriteLine("Обработка всех дат:");
        processor.ProcessAllDates();

        Console.WriteLine("\nОперации с датами:");
        processor.DisplayDateOperations("25/12/2023", "01/01/2024", 7);

        Console.WriteLine("\nПримеры использования отдельных компонентов:");

        // Демонстрация работы отдельных компонентов
        string converted = DateFormatter.ConvertDateFormat("25/12/2023", DateConstants.FormatMMDDYYYY);
        Console.WriteLine($"Конвертированная дата: {converted}");

        bool isValid = DateValidator.IsValidDateString("31/02/2023");
        Console.WriteLine($"Дата 31/02/2023 валидна?: {isValid}");

        bool isLeap = DateValidator.IsLeapYear(2024);
        Console.WriteLine($"2024 год високосный?: {isLeap}");

        DateTime date1 = DateParser.ParseDate("15/06/2023");
        DateTime date2 = DateParser.ParseDate("20/06/2023");
        int diff = DateCalculator.GetDaysDifference(date1, date2);
        Console.WriteLine($"Разница между 15/06/2023 и 20/06/2023: {diff} дней");
    }
}