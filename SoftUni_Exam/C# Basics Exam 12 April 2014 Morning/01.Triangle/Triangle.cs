using System;

class Triangle
{
    static void Main()
    {
        int pointAx = int.Parse(Console.ReadLine());
        int pointAy = int.Parse(Console.ReadLine());
        int pointBx = int.Parse(Console.ReadLine());
        int pointBy = int.Parse(Console.ReadLine());
        int pointCx = int.Parse(Console.ReadLine());
        int pointCy = int.Parse(Console.ReadLine());
        double distA = CalcLenght(pointAx, pointAy, pointBx, pointBy);
        double distB = CalcLenght(pointBx, pointBy, pointCx, pointCy);
        double distC = CalcLenght(pointAx, pointAy, pointCx, pointCy);
        if (distA + distB > distC && distB + distC > distA && distA + distC > distB)
        {
            double triangArea = CalcArea(distA, distB, distC);
            Console.WriteLine("Yes");
            Console.WriteLine("{0:F2}", triangArea);
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine("{0:F2}", distA);
        }
    }

    static double CalcArea(double distA, double distB, double distC)
    {
        double halfPerim = (distA + distB + distC) / 2;
        double area = Math.Sqrt(halfPerim * (halfPerim - distA) * (halfPerim - distB) * (halfPerim - distC));
        return area;
    }

    static double CalcLenght(int coorX1, int coorY1, int coorX2, int coorY2)
    {
        double d = Math.Pow((coorX2 - coorX1), 2) + Math.Pow((coorY2 - coorY1), 2);
        double dist = Math.Sqrt(d);
        return dist;
    }
}