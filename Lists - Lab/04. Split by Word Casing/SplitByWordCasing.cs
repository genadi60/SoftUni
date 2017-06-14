using System;
using System.Collections.Generic;

public class SplitByWordCasing
{
	public static void Main()
	{
		string[] separators = 
			{ ",", ".", "!", "(", ";", ":", " ", ")", "\"", "'", "\\", "/", "[", "]"};
		string[] userInput = Console.ReadLine()
			.Split(separators, StringSplitOptions.RemoveEmptyEntries);
		List<string> lettersLowercase = new List<string>();
		List<string> lettersUppercase = new List<string>();
		List<string> lettersMixed = new List<string>();
		for (int i = 0; i < userInput.Length; i++)
		{
			var controlString = userInput[i];
			bool isLovercase = true;
			bool isUppercase = true;
			for (int j = 0; j < controlString.Length; j++)
			{
				if (controlString[j] >= 'a' && controlString[j] <= 'z')
				{
					isUppercase = false;
				}
				else if(controlString[j] >= 'A' && controlString[j] <= 'Z')
				{
					isLovercase = false;
				}
				else
				{
					isUppercase = false;
					isLovercase = false;
				}
			}
			if (!isUppercase && isLovercase)
			{
				lettersLowercase.Add(controlString);
			}
			else if (isUppercase && !isLovercase)
			{
				lettersUppercase.Add(controlString);
			}
			else
			{
				lettersMixed.Add(controlString);
			}
		}

		Console.WriteLine($"Lower-case: {string.Join(", ", lettersLowercase)}");
		Console.WriteLine($"Mixed-case: {string.Join(", ", lettersMixed)}");
		Console.WriteLine($"Upper-case: {string.Join(", ", lettersUppercase)}");
	}
}