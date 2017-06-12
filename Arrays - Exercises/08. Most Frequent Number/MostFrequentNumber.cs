using System;
using System.Linq;

public class MostFrequentNumber
{
	public static void Main()
	{
		var numbers = Console.ReadLine()
			.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
			.Select(int.Parse)
			.ToList();
		var count = 0;
		var result = numbers[0];
		var maxCount = int.MinValue;
		while (numbers.Count > maxCount)
		{
			for (int i = 1; i < numbers.Count; i++)
			{
				if (numbers[0] == numbers[i])
				{
					count++;
					numbers.RemoveAt(i);
					i--;
				}
			}
			count++;
			if (count > maxCount)
			{
				maxCount = count;
				result = numbers[0];
			}
			numbers.RemoveAt(0);
			count = 0;
		}
		
		Console.WriteLine(result);
	}
}