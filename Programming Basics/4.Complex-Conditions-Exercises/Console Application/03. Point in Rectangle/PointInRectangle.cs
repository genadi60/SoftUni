using System;

class PointInRectangle
{
    static void Main()
    {
        double[] coordin = new double[6];
        for (int i = 0; i < 6; i++)
        {
            coordin[i] = double.Parse(Console.ReadLine());
        }
        double x1 = coordin[0];
        double y1 = coordin[1];
        double x2 = coordin[2];
        double y2 = coordin[3];
        double x = coordin[4];
        double y = coordin[5];
        if (x <= x2 && x >= x1 && y <= y2 && y >= y1)
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Outside");
        }
    }
}