namespace DateLibrary;

public class DateManager
{
    private List<string> dates = new List<string>();

    public void AddDate(string date)
    {
        dates.Add(date);
    }

    public void ProcessAllDates()
    {
        foreach (var date in dates)
        {
            var parts = date.Split('/');
            if (parts.Length == 3)
            {
                int y = int.Parse(parts[2]), m = int.Parse(parts[1]), d = int.Parse(parts[0]);
                if (DateUtils.CheckDate(y, m, d))
                {
                    DateTime dt = new DateTime(y, m, d);
                    Console.WriteLine($"{date} - {DateUtils.GetDayOfWeek(dt)}");
                }
            }
        }
    }

    public bool ValidateDate(string date)
    {
        var parts = date.Split('/');
        if (parts.Length != 3) return false;
            
        try
        {
            int y = int.Parse(parts[2]), m = int.Parse(parts[1]), d = int.Parse(parts[0]);
            return DateUtils.CheckDate(y, m, d);
        }
        catch
        {
            return false;
        }
    }
}