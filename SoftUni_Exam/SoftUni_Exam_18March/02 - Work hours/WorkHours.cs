using System;

class WorkHours
{
    static void Main()
    {
        int hours = int.Parse(Console.ReadLine());
        int workers = int.Parse(Console.ReadLine());
        int workDays = int.Parse(Console.ReadLine());
        int workHours = 8;
        int workTime = workers * workDays * workHours;
        if (workTime >= hours)
        {
            Console.WriteLine("{0} hours left", workTime - hours);
        }
        else
        {
            Console.WriteLine("{0} overtime", hours - workTime);
            Console.WriteLine("Penalties: {0}", (hours - workTime) * workDays);
        }
    }
}