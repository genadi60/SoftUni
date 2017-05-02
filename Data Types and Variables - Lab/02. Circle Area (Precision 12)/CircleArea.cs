using System;

class CircleArea
{
    static void Main()
    {
        double radius = double.Parse(Console.ReadLine());
        Console.WriteLine("{0:F12}", Math.PI * radius * radius);
    }
}