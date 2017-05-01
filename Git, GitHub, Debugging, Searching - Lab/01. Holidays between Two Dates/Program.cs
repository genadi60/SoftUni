using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        CultureInfo culture = CultureInfo.CreateSpecificCulture("fr-FR");
        var startDate = DateTime.Parse(Console.ReadLine(), culture, DateTimeStyles.None);
        var endDate = DateTime.Parse(Console.ReadLine(), culture, DateTimeStyles.None);
        var holidaysCount = 0;
        for (var date = startDate; date <= endDate; date = date.AddDays(1))
        {
            if (date.DayOfWeek == DayOfWeek.Saturday ||
               date.DayOfWeek == DayOfWeek.Sunday)
            {
                holidaysCount++;
            }
        }
            
        Console.WriteLine(holidaysCount);
    }
}
