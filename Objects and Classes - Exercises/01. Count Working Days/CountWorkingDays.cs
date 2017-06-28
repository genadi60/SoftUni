using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

public class CountWorkingDays
{
    public static void Main()
    {
        var startDateAsText = Console.ReadLine();
        DateTime startDate = DateTime.ParseExact(startDateAsText, "d-M-yyyy", CultureInfo.InvariantCulture);
        var endDateAsText = Console.ReadLine();
        DateTime endDate = DateTime.ParseExact(endDateAsText, "d-M-yyyy", CultureInfo.InvariantCulture);
        var holidays = new Dictionary<int, int[]>()
        {
            {1, new int[]{1}},
            {3, new int[]{3}},
            {5, new int[]{1, 6, 24}},
            {9, new int[]{6, 22}},
            {11, new int[]{1}},
            {12, new int[]{24, 25, 26}}
        };
        endDate = endDate.AddDays(1);
        var countHolidays = 0;
        var countDays = 0;
        while (startDate != endDate)
        {
            if (startDate.DayOfWeek == DayOfWeek.Saturday || startDate.DayOfWeek == DayOfWeek.Sunday)
            {
                countHolidays++;
            }
            if (startDate.DayOfWeek != DayOfWeek.Saturday && startDate.DayOfWeek != DayOfWeek.Sunday)
            {
                if (holidays.ContainsKey(startDate.Month))
                {
                    if (holidays[startDate.Month].Contains(startDate.Day))
                    {
                        countHolidays++;
                    }
                }
            }
            countDays++;
            startDate = startDate.AddDays(1);
        }
        var workingDays = countDays - countHolidays;
        Console.WriteLine(workingDays);
    }
}