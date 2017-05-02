using System;

class ExactSumOfRealNumbers
{
    static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        decimal sum = 0M;
        for (int i = 0; i < count; i++)
        {
            decimal arg = decimal.Parse(Console.ReadLine());
            sum += arg;
        }
        Console.WriteLine(sum);
    }
}