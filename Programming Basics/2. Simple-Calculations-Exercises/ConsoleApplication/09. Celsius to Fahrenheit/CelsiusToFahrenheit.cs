using System;

class CelsiusToFahrenheit
{
    static void Main()
    {
        var celsius = double.Parse(Console.ReadLine());
        var fahrenheit = celsius * 9 / 5 + 32;
        Console.WriteLine(Math.Round(fahrenheit, 2));
    }
}