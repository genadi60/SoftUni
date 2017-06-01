using System;

class BackIn30Minutes
{
    static void Main()
    {
        var hours = int.Parse(Console.ReadLine());
        var minutes = int.Parse(Console.ReadLine());
        var minutesAfter30Minutes = (minutes + 30) % 60;
        var hoursAfter30Minutes = (hours + (minutes + 30) / 60) % 24;
        Console.WriteLine($"{hoursAfter30Minutes}:{minutesAfter30Minutes:D2}");
    }
}