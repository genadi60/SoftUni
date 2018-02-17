using System;
using System.Linq;
using System.Text.RegularExpressions;

public class MatchDates
{
    public static void Main()
    {
       var pattern = @"\b(?<day>\d{2})([-.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
        var dates = Regex.Matches(Console.ReadLine(), pattern);
        foreach (Match date in dates)
        {
            var day = date.Groups["day"].Value;
            var month = date.Groups["month"].Value;
            var year = date.Groups["year"].Value;
            Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
        }
    }
}