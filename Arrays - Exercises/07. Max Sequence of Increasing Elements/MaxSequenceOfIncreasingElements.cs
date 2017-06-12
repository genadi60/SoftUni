using System;
using System.Linq;

public class MaxSequenceOfIncreasingElements
{
	public static void Main()
	{
		var inputString = Console.ReadLine()
			.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
			.Select(long.Parse)
			.ToArray();
		var maxCount = int.MinValue;
		var count = 1;
		
		var index = 0;
		for (int i = 1; i < inputString.Length; i++)
		{
			if (inputString[i] > inputString[i - 1])
			{
				count++;
				
				if (count > maxCount && count > 1)
				{
					maxCount = count;
					index = i;
				}
			}
			else
			{
				count = 1;
			}
		}
		if (maxCount > 1)
		{
			for (int i = index - (maxCount -1) ; i <= index; i++)
			{
				Console.Write($"{inputString[i]} ");
			}
			Console.WriteLine();
		}
		else
		{
			Console.WriteLine(inputString[0]);
		}
	}
}