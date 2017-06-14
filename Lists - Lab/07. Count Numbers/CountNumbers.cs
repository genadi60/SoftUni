using System;
using System.Linq;

public class CountNumbers
{
	public static void Main()
	{
		var count = new int[1001];
		var numbers = Console.ReadLine()
			.Split(' ')
			.Select(int.Parse)
			.ToList();
		numbers.Sort();
		foreach (var number in numbers)
		{
			count[number]++;
		}
		for (int i = 0; i < count.Length; i++)
		{
			if (count[i] > 0)
			{
				Console.WriteLine($"{i} -> {count[i]}");
			}
		}
	}
}