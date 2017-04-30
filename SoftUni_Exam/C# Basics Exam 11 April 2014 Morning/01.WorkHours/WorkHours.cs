using System;

class WorkHours
{
    static void Main()
    {
        int required = int.Parse(Console.ReadLine());
        int daysToFinish = int.Parse(Console.ReadLine());
        double productivity = double.Parse(Console.ReadLine());
        double realWorkDays = daysToFinish - daysToFinish * 0.1;
        int realWorkHours = (int)(realWorkDays * 12 * productivity/100);
        int difference = realWorkHours - required;
        if(difference < 0)
        {
            Console.WriteLine("No");
        }
        else
        {
            Console.WriteLine("Yes");
        }
        Console.WriteLine(difference);
    }
}