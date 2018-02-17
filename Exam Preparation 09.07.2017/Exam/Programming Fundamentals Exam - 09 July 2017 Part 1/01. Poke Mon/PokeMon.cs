using System;

public class PokeMon
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());
        decimal half = n / 2.00m;
        var count = 0;
        while (n >= m)
        {
            n = n - m;
            if (n == half && y > 0)
            {
                n /= y;
            }
            count++;
        }
        Console.WriteLine(n);
        Console.WriteLine(count);
    }
}