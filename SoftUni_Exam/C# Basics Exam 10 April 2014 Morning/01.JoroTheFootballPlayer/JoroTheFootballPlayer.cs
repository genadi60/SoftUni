using System;

class JoroTheFootballPlayer
{
    static void Main()
    {
        string yearType = Console.ReadLine();
        int numberOfHolidays = int.Parse(Console.ReadLine());
        int weekendsHome = int.Parse(Console.ReadLine());
        int weekends = 52;
        int normalWeek = weekends - weekendsHome;
        double plays = weekendsHome + normalWeek * 2.0 / 3 + numberOfHolidays * 1.0 / 2;
        if (yearType == "t")
        {
            plays += 3;
        }
        Console.WriteLine("{0}", (int)plays);
    }
}