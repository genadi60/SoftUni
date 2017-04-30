using System;

class SumSeconds
{
    static void Main()
    {
        int number = 3;
        int time = 0;
        for (int i = 0; i < number; i++)
        {
            time += int.Parse(Console.ReadLine());
        }
        int minute = time / 60;
        int seconds = time % 60;
        Console.WriteLine("{0}:{1:D2}", minute, seconds);
    }
}