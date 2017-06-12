using System;

public class GreaterOfTwoValues
{
	public static void Main()
	{
		var typeOfValues = Console.ReadLine().ToLower();
		switch (typeOfValues)
		{
			case "int":
				var firstValue = int.Parse(Console.ReadLine());
				var secondValue = int.Parse(Console.ReadLine());
				Console.WriteLine(GetMax(firstValue, secondValue));
				break;
			case "char":
				var firstChar = char.Parse(Console.ReadLine());
				var secondChar = char.Parse(Console.ReadLine());
				Console.WriteLine(GetMax(firstChar, secondChar));
				break;
			case "string":
				var firstString = Console.ReadLine();
				var secondString = Console.ReadLine();
				Console.WriteLine(GetMax(firstString, secondString));
				break;
			default:
				break;
		}
	}

	static int GetMax(int firstValue, int secondValue)
	{
		var result = Math.Max(firstValue, secondValue);
		return result;
	}

	static char GetMax(char firstChar, char secondChar)
	{
		var result =(char)Math.Max(firstChar, secondChar);
		return result;
	}

	static string GetMax(string firstString, string secondString)
	{
		var result = string.Empty;
		var compare = string.Compare(firstString, secondString);
		if (compare >= 0)
		{
			result = firstString;
		}
		else
		{
			result = secondString;
		}
		return result;
	}
}