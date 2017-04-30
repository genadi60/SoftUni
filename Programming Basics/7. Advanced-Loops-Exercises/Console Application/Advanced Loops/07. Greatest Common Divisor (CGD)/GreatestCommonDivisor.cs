using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int max = Math.Max(a, b);
        int min = a + b - max;
        a = max % min;
        
        while(a != 0)
        {
            max = min;
            min = a;
            a = max % min;
        }
        Console.WriteLine(min);
    }
}