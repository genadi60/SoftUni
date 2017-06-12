using System;

public class GeometryCalculator
{
	public static void Main()
	{
		var figureType = Console.ReadLine().ToLower();
		var area = 0.0;
		switch (figureType)
		{
			case "triangle":
				var side = double.Parse(Console.ReadLine());
				var height = double.Parse(Console.ReadLine());
				area = height * side / 2.0;
				break;
			case "square":
				side = double.Parse(Console.ReadLine());
				area = side * side;
				break;
			case "rectangle":
				var width = double.Parse(Console.ReadLine());
				height = double.Parse(Console.ReadLine());
				area = width * height;
				break;
			case "circle":
				var radius = double.Parse(Console.ReadLine());
				area = radius * radius * Math.PI;
				break;
			default:
				break;
		}
		Console.WriteLine("{0:F2}", area);
	}
}