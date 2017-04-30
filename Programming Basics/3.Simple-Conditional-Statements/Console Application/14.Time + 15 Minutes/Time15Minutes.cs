using System;

class Time15Minutes
{
    static void Main()
    {
        var hours = int.Parse(Console.ReadLine());
        var minutes = int.Parse(Console.ReadLine());
        var minAfter = minutes + 15;
        if(minAfter >= 60)
        {
            minAfter = minAfter % 60;
            hours++;
            if(hours >= 24)
            {
                hours = hours % 24;
            }
        }
        Console.WriteLine("{0}:{1:D2}", hours, minAfter);
    }
}