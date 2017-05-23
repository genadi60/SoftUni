using System;

class MilesToKilometers
{
    const double mile = 1.60934;
    static void Main()
    {
        Console.WriteLine("{0:F2}", double.Parse(Console.ReadLine()) * mile);
    }
}