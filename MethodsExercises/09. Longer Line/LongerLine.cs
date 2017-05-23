using System;

class LongerLine
{
    static void Main()
    {
        double[] fourPointsCoordinates = new double[8];
        for (int i = 0; i < fourPointsCoordinates.Length; i++)
        {
            fourPointsCoordinates[i] = double.Parse(Console.ReadLine());
        }
        double x1, x2, x3, x4, y1, y2, y3, y4;
        x1 = fourPointsCoordinates[0];
        y1 = fourPointsCoordinates[1];
        x2 = fourPointsCoordinates[2];
        y2 = fourPointsCoordinates[3];
        x3 = fourPointsCoordinates[4];
        y3 = fourPointsCoordinates[5];
        x4 = fourPointsCoordinates[6];
        y4 = fourPointsCoordinates[7];

        if (LineLength(x1, y1, x2, y2) >= LineLength(x3, y3, x4, y4))
        {
            if (DistanceToCentre(x1, y1) <= DistanceToCentre(x2, y2))
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
        else
        {
            if (DistanceToCentre(x3, y3) <= DistanceToCentre(x4, y4))
            {
                Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
            }
            else
            {
                Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
            }
        }
    }

    static double LineLength(double x1, double y1, double x2, double y2)
    {
        double result = 0.0;
        result = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
        return result;
    }

    static double DistanceToCentre(double x, double y)
    {
        double result = 0.0;
        result = Math.Sqrt(x * x + y * y);
        return result;
    }
}