using System;
using System.Linq;

public class MaxSequenceOfEqualElements
{
	public static void Main()
	{
		var inputString = Console.ReadLine()
			.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
			.Select(long.Parse)
			.ToArray();
		var maxCount = int.MinValue;
		var count = 1;
		var number = 0L;
		for (int i = 1; i < inputString.Length; i++)
		{
			if (inputString[i] == inputString[i - 1])
			{
				count++;
				if (count > maxCount && count > 1)
				{
					maxCount = count;
					number = inputString[i];
				}
			}
			else
			{
				count = 1;
			}
		}
		if (maxCount > 1)
		{
			for (int i = 0; i < maxCount; i++)
			{
				Console.Write($"{number} ");
			}
			Console.WriteLine();
		}
		else
		{
			Console.WriteLine(inputString[0]);
		}
	}
}