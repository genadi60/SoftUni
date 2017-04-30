using System;

class Volleyball
{
    static void Main()
    {
        string year = Console.ReadLine();
        int holidays = int.Parse(Console.ReadLine());
        int travelWeekends = int.Parse(Console.ReadLine());
        int weekends = 48;
        double volleyballPlay = (weekends - travelWeekends) * 3 / 4.0 + travelWeekends + holidays * 2 / 3.0;
        if(year == "leap")
        {
            volleyballPlay += volleyballPlay * 15 / 100.0;
        }
        Console.WriteLine((int)volleyballPlay);
    }
}