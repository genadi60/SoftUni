using System;
using System.Collections.Generic;
using System.Linq;

public class SumAdjacentEqualNumbers
{
	public static void Main()
	{
		
		var userInput = Console.ReadLine();
		var numbers = userInput
			.Split(' ')
			.Select(decimal.Parse)
			.ToList();
		bool isEqual = true;
		while (isEqual)
		{
			isEqual = false;
			for (int i = 0; i < numbers.Count - 1; i++)
			{
				if (numbers[i] == numbers[i + 1])
				{ 
					var sum = numbers[i + 1] + numbers[i];
					numbers.RemoveRange(i, 2);
					numbers.Insert(i, sum);
					isEqual = true;
				}
			}
		}
		Console.WriteLine(string.Join(" ", numbers));
	}
}