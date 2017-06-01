using System;

public class FastPrimeChecker
{
    public static void Main()
    {
        var number = int.Parse(Console.ReadLine());
        for (int i = 2; i <= number; i++)
        {
            bool condition = true;
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                {
                    condition = false;
                    break;
                }
            }
            Console.WriteLine($"{i} -> {condition}");
        }
    }
}