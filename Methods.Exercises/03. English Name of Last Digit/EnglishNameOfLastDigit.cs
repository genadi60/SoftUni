using System;

public class EnglishNameOfLastDigit
{
	public static void Main()
	{
		
		var number = long.Parse(Console.ReadLine());
		
		var englishName = GetEnglishNameOfLastDigit(number);
		Console.WriteLine(englishName);
	}

	static string GetEnglishNameOfLastDigit(long a)
	{
		var result = string.Empty;
		var lastDigit = Math.Abs(a) % 10;
		switch (lastDigit)
		{
			case 0:
				result = "zero";
				break;
			case 1:
				result = "one";
				break;
			case 2:
				result = "two";
				break;
			case 3:
				result = "three";
				break;
			case 4:
				result = "four";
				break;
			case 5:
				result = "five";
				break;
			case 6:
				result = "six";
				break;
			case 7:
				result = "seven";
				break;
			case 8:
				result = "eight";
				break;
			case 9:
				result = "nine";
				break;
		}
		return result;
	}
}