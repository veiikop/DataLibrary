namespace DateLibrary;

class Program
{
    static void Main(string[] args)
    {
        DateManager manager = new DateManager();
        
        manager.AddDate("25/12/2023");
        manager.AddDate("01/01/2024");
        manager.AddDate("29/02/2024"); 
        
        Console.WriteLine("Обработка всех дат:");
        manager.ProcessAllDates();
        
        Console.WriteLine("\nОперации с датами:");
        DateUtils.ProcessAllDateOperations("25/12/2023", "01/01/2024", 7);
        
        Console.WriteLine("\nПримеры проблемного кода:");
        
        string converted = DateUtils.ConvertDate("25/12/2023", 1);
        Console.WriteLine($"Конвертированная дата: {converted}");
        
        bool isLeap = DateUtils.IsLeapYear(2024);
        Console.WriteLine($"2024 год високосный?: {isLeap}");
    }
}