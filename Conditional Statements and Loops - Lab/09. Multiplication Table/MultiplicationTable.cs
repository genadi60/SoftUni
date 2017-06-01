using System;

class MultiplicationTable
{
    static void Main()
    {
        var number = long.Parse(Console.ReadLine());
        long result = 0L;
        for (int i = 1; i <= 10; i++)
        {
            result = number * i;
            Console.WriteLine($"{number} X {i} = {result}");
        }
    }
}