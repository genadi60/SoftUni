using System;

class TriangleArea
{
    static void Main()
    {
        var side = double.Parse(Console.ReadLine());
        var h = double.Parse(Console.ReadLine());
        var area = side * h / 2;
        Console.WriteLine("Triangle area = {0}", Math.Round(area, 2));
    }
}