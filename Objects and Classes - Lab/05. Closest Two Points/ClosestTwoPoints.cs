using System;
using System.Collections.Generic;
using System.Linq;

public class ClosestTwoPoints
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
    public static void Main()
    {
        var points = new List<Point>();
        var pointsNumber = int.Parse(Console.ReadLine());
        for (int i = 0; i < pointsNumber; i++)
        {
            var pointCoordinate = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            var point = generatePoint(pointCoordinate);
            points.Add(point);
        }
        var distanceMin = double.MaxValue;
        var point1Index = 0;
        var point2Index = 0;
        for (int i = 0; i < points.Count - 1; i++)
        {
            for (int j = i + 1; j <points.Count; j++)
            {
                var distance = calculateDistanceBetweenTwoPoints(points[i], points[j]);
                if (distance < distanceMin)
                {
                    distanceMin = distance;
                    point1Index = i;
                    point2Index = j;
                }
            }
        }
        Console.WriteLine($"{distanceMin:F3}");
        Console.WriteLine($"({points[point1Index].X}, {points[point1Index].Y})");
        Console.WriteLine($"({points[point2Index].X}, {points[point2Index].Y})");
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