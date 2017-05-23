using System;

class RectangleArea
{
    static void Main()
    {
        var width = double.Parse(Console.ReadLine());
        var height = double.Parse(Console.ReadLine());
        double rectArea = width * height;
        Console.WriteLine("{0:F2}", rectArea);
    }
}