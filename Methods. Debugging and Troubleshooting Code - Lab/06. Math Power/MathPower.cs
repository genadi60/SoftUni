using System;

public class MathPower
{
	public static void Main()
	{
		var number = double.Parse(Console.ReadLine());
		var power = double.Parse(Console.ReadLine());
		Console.WriteLine(ReiseToPower(number, power));
	}

	static double ReiseToPower(double number, double power)
	{
		double result = Math.Pow(number, power);
		return result;
	}
}