using System;

class GeometryCalculator
{
    static void Main()
    {
        var figure = Console.ReadLine().ToLower();
        double result = 0.0;
        switch (figure)
        {
            case "triangle":
                result = TriangleArea(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                break;
            case "square":
                result = SquareArea(double.Parse(Console.ReadLine()));
                break;
            case "rectangle":
                result = RectangleArea(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine()));
                break;
            case "circle":
                result = CircleArea(double.Parse(Console.ReadLine()));
                break;
        }
        Console.WriteLine("{0:F2}", result);
    }

    static double CircleArea(double radius)
    {
        double result = radius * radius * Math.PI;
        return result;
    }

    static double RectangleArea(double width, double height)
    {
        double result = width * height;
        return result;
    }

    static double TriangleArea(double side, double height)
    {
        double result = (side * height) / 2.0;
        return result;
    }

    static double SquareArea(double side)
    {
        double result = side * side;
        return result;
    }
}