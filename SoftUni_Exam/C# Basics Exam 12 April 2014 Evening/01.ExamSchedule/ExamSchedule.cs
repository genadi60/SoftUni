using System;
using System.Globalization;

class ExamSchedule
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int minutes = int.Parse(Console.ReadLine());
        string partOfTheDay = Console.ReadLine();
        int durationHours = int.Parse(Console.ReadLine());
        int durationMinutes = int.Parse(Console.ReadLine());
        string examFinal = CalculateExamDuration(hours, minutes, partOfTheDay, durationHours, durationMinutes);
        
        Console.WriteLine(examFinal);
    }

    static string CalculateExamDuration(int hours, int minutes, string partOfTheDay, int durationHours, int durationMinutes)
    {
        string duration = string.Empty;
        if(partOfTheDay == "PM")
        {
            hours += 12;
        }

        if (minutes + durationMinutes >= 60)
        {
            minutes = (minutes + durationMinutes) % 60;
            hours++;
        }
        else
        {
            minutes = (minutes + durationMinutes);
        }
        if (hours + durationHours >= 24)
        {
            hours = (hours + durationHours) % 24;
        }
        else
        {
            hours = (hours + durationHours);
        }
        DateTime time;
        time = new DateTime(2008, 1, 1, hours, minutes, 1);
        duration = time.ToString("hh:mm:tt", CultureInfo.InvariantCulture);
        return duration;
    }
}