using System;

class CircleAreaAndPerimeter
{
    static void Main()
    {
        var r = double.Parse(Console.ReadLine());
        var area = Math.PI * r * r;
        var perimeter = Math.PI * r * 2.0;
        Console.WriteLine("Area = {0}", area);
        Console.WriteLine("Perimeter = {0}", perimeter);
    }
}