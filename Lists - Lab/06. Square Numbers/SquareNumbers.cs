using System;
using System.Collections.Generic;
using System.Linq;

public class SquareNumbers
{
	public static void Main()
	{
		List<long> squareNumbers = new List<long>();
		var numbers = Console.ReadLine()
			.Split(' ')
			.Select(long.Parse)
			.ToList();
		for (int i = 0; i < numbers.Count; i++)
		{
			if (Math.Sqrt(numbers[i]) == (int)Math.Sqrt(numbers[i]))
			{
				squareNumbers.Add(numbers[i]);
			}
		}
		squareNumbers.Sort();
		squareNumbers.Reverse();
		Console.WriteLine(string.Join(" ", squareNumbers));
	}
}