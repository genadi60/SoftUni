using System;
using System.Linq;

public class RemoveNegativesAndReverse
{
	public static void Main()
	{
		var numbers = Console.ReadLine()
			.Split(' ')
			.Select(int.Parse)
			.Where(x => x >= 0)
			.Reverse()
			.ToList();
		if (numbers.Count > 0)
		{
			Console.WriteLine(string.Join(" ", numbers));
		}
		else
		{
			Console.WriteLine("empty");
		}
	}
}