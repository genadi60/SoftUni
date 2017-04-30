using System;

class Volleyball
{
    static void Main()
    {
        string yearType = Console.ReadLine();
        int numberOfHolidays = int.Parse(Console.ReadLine());
        int weekendsHome = int.Parse(Console.ReadLine());
        int weekends = 48;
        int normalWeek = weekends - weekendsHome;
        double plays = weekendsHome + normalWeek * 3.0 / 4 + numberOfHolidays * 2.0 / 3;
        if(yearType == "leap")
        {
            plays += (plays / 100) * 15;
        }
        Console.WriteLine("{0}", (int)plays);
    }
}