using System;

class OddNumber
{
    static void Main()
    {
        var number = Math.Abs(int.Parse(Console.ReadLine()));
        while (number % 2 == 0)
        {
            Console.WriteLine("Please write an odd number.");
            number = Math.Abs(int.Parse(Console.ReadLine()));
        }
        Console.WriteLine($"The number is: {number}");
    }
}