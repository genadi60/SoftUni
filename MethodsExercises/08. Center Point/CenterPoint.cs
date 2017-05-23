using System;
using System.Linq;

class CenterPoint
{
    static void Main()
    {
        double[] twoPointsCoordinates = new double[4];
        for (int i = 0; i < twoPointsCoordinates.Length; i++)
        {
            twoPointsCoordinates[i] = double.Parse(Console.ReadLine());
        }
        double x1, x2, y1, y2;
        x1 = twoPointsCoordinates[0];
        y1 = twoPointsCoordinates[1];
        x2 = twoPointsCoordinates[2];
        y2 = twoPointsCoordinates[3];

        if (DistanceToCentre(x1, y1) <= DistanceToCentre(x2, y2))
        {
            Console.WriteLine($"({x1}, {y1})");
        }
        else
        {
            Console.WriteLine($"({x2}, {y2})");
        }
       

    }

    static double DistanceToCentre(double x, double y)
    {
        double result = 0.0;
        result = Math.Sqrt(Math.Pow(x, 2.0) + Math.Pow(y, 2.0));
        return result;
    }
}