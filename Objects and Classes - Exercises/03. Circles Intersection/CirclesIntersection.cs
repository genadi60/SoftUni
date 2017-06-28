using System;
using System.Linq;

public class CirclesIntersection
{
    class Circle
    {
        public double Radius { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
    }
    
    public static void Main()
    {
        var firstCircle = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();
        var secondCircle = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToArray();
        var circ1 = new Circle();
        var circ2 = new Circle();
        circ1.X = firstCircle[0];
        circ1.Y = firstCircle[1];
        circ1.Radius = firstCircle[2];
        circ2.X = secondCircle[0];
        circ2.Y = secondCircle[1];
        circ2.Radius = secondCircle[2];
        var intersect = string.Empty;
        if (calculateDistanceBetweenCenters(circ1, circ2))
        {
            intersect = "Yes";
        }
        else
        {
            intersect = "No";
        }

        Console.WriteLine(intersect);
    }

    static bool calculateDistanceBetweenCenters(Circle circ1, Circle circ2)
    {
        var distance = Math.Sqrt(Math.Pow((circ1.X - circ2.X), 2) + Math.Pow((circ1.Y - circ2.Y), 2));
        bool intersect = false;
        if (distance <= (circ1.Radius + circ2.Radius))
        {
            intersect = true;
        }
        return intersect;
    }
}