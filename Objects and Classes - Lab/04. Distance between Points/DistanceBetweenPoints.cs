using System;
using System.Linq;

public class DistanceBetweenPoints
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    public static void Main()
    {
        var firstPoint = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();
        var secondpoint = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();
        var point1 = generatePoint(firstPoint);
        var point2 = generatePoint(secondpoint);
        var distance = calculateDistanceBetweenTwoPoints(point1, point2);
        Console.WriteLine("{0:F3}", distance);
    }

    static Point generatePoint(double[] coordinates)
    {
        var point = new Point();
        point.X = coordinates[0];
        point.Y = coordinates[1];
        return point;
    }

    static double calculateDistanceBetweenTwoPoints(Point p1, Point p2)
    {
        var distance = Math.Sqrt(Math.Pow((p1.X - p2.X), 2) + Math.Pow((p1.Y - p2.Y), 2));
        return distance;
    }
}