using System;

class Firm
{
    static void Main()
    {
        ulong hours = ulong.Parse(Console.ReadLine());
        ulong days = ulong.Parse(Console.ReadLine());
        ulong staff = ulong.Parse(Console.ReadLine());
        ulong availableDays = (days * 9) / 10;
        ulong workingHours = (ulong)((days * 8) * 90 / 100.0 + staff * 2 * days);
        if (workingHours >= hours)
        {
            Console.WriteLine("Yes!{0} hours left.", workingHours - hours);
        }
        else
        {
            Console.WriteLine("Not enough time!{0} hours needed.", hours - workingHours);
        }
    }
}