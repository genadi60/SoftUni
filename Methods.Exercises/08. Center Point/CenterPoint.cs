using System;
using System.Runtime.InteropServices;

public class CenterPoint
{
	public static void Main()
	{
		var x1 = double.Parse(Console.ReadLine());
		var y1 = double.Parse(Console.ReadLine());
		var x2 = double.Parse(Console.ReadLine());
		var y2 = double.Parse(Console.ReadLine());
		Console.WriteLine("(" + String.Join(", ", PointClosestToCenterPoint(x1, y1, x2, y2)) + ")");
		;
	}

	private static double[] PointClosestToCenterPoint(double x1, double y1, double x2, double y2)
	{
		double[] area = new double[2];
		var firstDistance = Math.Sqrt(x1 * x1 + y1 * y1);
		var secondDistance = Math.Sqrt(x2 * x2 + y2 * y2);
		if (firstDistance <= secondDistance)
		{
			area[0] = x1;
			area[1] = y1;
		}
		else
		{
			area[0] = x2;
			area[1] = y2;
		}
		return area;
	}
}