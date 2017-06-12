using System;
using System.Collections.Generic;

public class SieveOfEratosthenes
{
	public static void Main()
	{
		var n = int.Parse(Console.ReadLine());
		List<int> numbers = new List<int>();
		for (int i = 2; i <= n; i++)
		{
			numbers.Add(i);
		}
		var k = 0;
		for (int i = k + 1; i < numbers.Count; i++)
		{
			for (int j = k + 1; j < numbers.Count; j++)
			{
				if (numbers[j] % numbers[k] == 0)
				{
					numbers.Remove(numbers[j]);
				}
			}
			k++;
		}
		
		Console.WriteLine(string.Join(" ", numbers));
	}
}