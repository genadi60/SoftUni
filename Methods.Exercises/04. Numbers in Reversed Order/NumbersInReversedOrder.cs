using System;

public class NumbersInReversedOrder
{
	public static void Main()
	{
		var num = decimal.Parse(Console.ReadLine());
		Console.WriteLine(GetReverseNumber(num));
	}

	static decimal GetReverseNumber(decimal a)
	{
		var result = 0m;
		var sign = -1;
		if (a >= 0)
		{
			sign = 1;
		}
		var reversedString = string.Empty;
		var numberToString = a.ToString().TrimStart('-');
		foreach (var item in numberToString)
		{
			reversedString = item + reversedString;
		}
		result = decimal.Parse(reversedString) * sign;
		return result;
	}
}