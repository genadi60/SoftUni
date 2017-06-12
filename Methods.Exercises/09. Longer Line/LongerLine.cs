using System;
using System.Linq;

public class LongerLine
{
	public static void Main()
	{
		double[] firstLine = new double[4];
		double[] secondLine = new double[4];
		for (int i = 0; i < firstLine.Length; i++)
		{
			firstLine[i] = double.Parse(Console.ReadLine());
		}
		for (int i = 0; i < secondLine.Length; i++)
		{
			secondLine[i] = double.Parse(Console.ReadLine());
		}
		double[] result = PointClosestToCenterPoint(FindLongerLine(firstLine, secondLine)).ToArray();
		Console.WriteLine($"({result[0]}, {result[1]})({result[2]}, {result[3]})");
		;
	}

	static double[] FindLongerLine(double[] firstLine, double[] secondLine)
	{
		var firstLineLength = Math.Sqrt(Math.Pow((firstLine[2] - firstLine[0]), 2) +
		                                Math.Pow((firstLine[3] - firstLine[1]), 2));
		var secondLineLength = Math.Sqrt(Math.Pow((secondLine[2] - secondLine[0]), 2) +
		                                Math.Pow((secondLine[3] - secondLine[1]), 2));
		if (firstLineLength >= secondLineLength)
		{
			return firstLine;
		}
		else
		{
			return secondLine;
		}
	}

	private static double[] PointClosestToCenterPoint(double[] line)
	{
		double[] area = new double[4];
		var firstDistance = Math.Sqrt(Math.Pow(line[0], 2) + Math.Pow(line[1], 2));
		var secondDistance = Math.Sqrt(Math.Pow(line[2], 2) + Math.Pow(line[3], 2));
		if (firstDistance <= secondDistance)
		{
			return line;
		}
		else
		{
			area[0] = line[2];
			area[1] = line[3];
			area[2] = line[0];
			area[3] = line[1];
			return area;
		}
		
	}
}
