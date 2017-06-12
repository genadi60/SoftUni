using System;

public class MaxMethod
{
	public static void Main()
	{
		var firstNumber = int.Parse(Console.ReadLine());
		var secondNumber = int.Parse(Console.ReadLine());
		var thirdNumber = int.Parse(Console.ReadLine());
		var maxNumber = GetMax(firstNumber, secondNumber);
		maxNumber = GetMax(maxNumber, thirdNumber);
		Console.WriteLine(maxNumber);
	}

	static int GetMax(int a, int b)
	{
		var result = Math.Max(a, b);
		return result;
	}
}