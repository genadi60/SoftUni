using System;

class DogHouse
{
    static void Main()
    {
        decimal a = decimal.Parse(Console.ReadLine());
        decimal b = decimal.Parse(Console.ReadLine());
        decimal wallArea = 2 * a * a / 2.00m + 2 * a / 2.00m * a / 2.00m + (b - a / 2.00m) * a / 2.00m - a / 5.00m * a / 5.00m;
        decimal roofArea = 2 * a * a / 2.00m;
        decimal redColor = roofArea / 5.00m;
        decimal greenColor = wallArea / 3.00m;

        Console.WriteLine("{0:F2}", greenColor);
        Console.WriteLine("{0:F2}", redColor);
    }
}