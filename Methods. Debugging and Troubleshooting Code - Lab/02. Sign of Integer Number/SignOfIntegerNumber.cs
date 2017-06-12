using System;

public class SignOfIntegerNumber
{
	public static void Main()
	{
		var number = int.Parse(Console.ReadLine());
		Console.WriteLine($"The number {number} is {FindSignOfInteger(number)}.");

	}

	static string FindSignOfInteger(int number)
	{
		var result = string.Empty;
		
		if(number > 0)
		{
			result = "positive";
		}
		else if (number < 0)
		{
			result = "negative";
		}
		else
		{
			result = "zero";
		}	
	
		return result;
	}
}