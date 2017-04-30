using System;

class SoftUniCamp
{
    static void Main()
    {
        int groupNum = int.Parse(Console.ReadLine());
        decimal sum = 0.00m;
        int car = 0;
        int van = 0;
        int smallBus = 0;
        int bus = 0;
        int train = 0;
        for (int i = 0; i < groupNum; i++)
        {
            int passenger = int.Parse(Console.ReadLine());
            sum += passenger;
            if (passenger <= 5)
            {
                car += passenger;
            }
            else if (passenger <= 12)
            {
                van += passenger;
            }
            else if (passenger <= 25)
            {
                smallBus += passenger;
            }
            else if (passenger <= 40)
            {
                bus += passenger;
            }
            else
            {
                train += passenger;
            }
        }
        Console.WriteLine("{0:F2}%", car / sum * 100);
        Console.WriteLine("{0:F2}%", van / sum * 100);
        Console.WriteLine("{0:F2}%", smallBus / sum * 100);
        Console.WriteLine("{0:F2}%", bus / sum * 100);
        Console.WriteLine("{0:F2}%", train / sum * 100);
    }
}