using System;

public class CubeProperties
{
	public static void Main()
	{
		var sideOfCube = double.Parse(Console.ReadLine());
		var parameter = Console.ReadLine().ToLower();
		var result = 0.0;
		switch (parameter)
		{
			case "face":
				result = Math.Sqrt(2 * sideOfCube * sideOfCube);
				break;
			case "space":
				result = Math.Sqrt(3 * sideOfCube * sideOfCube);
				break;
			case "volume":
				result = sideOfCube * sideOfCube * sideOfCube;
				break;
			case "area":
				result = 6 * sideOfCube * sideOfCube;
				break;
			default:
				break;
		}
		Console.WriteLine($"{result:F2}");
	}
}