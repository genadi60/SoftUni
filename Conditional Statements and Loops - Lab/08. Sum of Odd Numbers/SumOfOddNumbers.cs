using System;

class SumOfOddNumbers
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var odd = -1;
        long sum = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(odd += 2);
            sum += odd;
        }
        Console.WriteLine($"Sum: {sum}");
    }
}