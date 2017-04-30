using System;

class Distance
{
    static void Main()
    {
        decimal velocity = decimal.Parse(Console.ReadLine());
        decimal firstTime = decimal.Parse(Console.ReadLine());
        decimal secondTime = decimal.Parse(Console.ReadLine());
        decimal thirdTime = decimal.Parse(Console.ReadLine());
        decimal distance = velocity * firstTime / 60.0m + (velocity + velocity / 10.0m) * secondTime / 60.0m + ((velocity + velocity / 10.0m) - (velocity + velocity / 10.0m) / 20.0m) * thirdTime / 60.0m;
        Console.WriteLine("{0:F2}",distance);
    }
}