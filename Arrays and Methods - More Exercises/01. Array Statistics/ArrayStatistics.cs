using System;
using System.Linq;

public class ArrayStatistics
{
	public static void Main()
	{
		var numbers = Console.ReadLine()
			.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
			.Select(long.Parse)
			.ToArray();
		var min = numbers.Min();
		var max = numbers.Max();
		var sum = numbers.Sum();
		var average = numbers.Average();
		Console.WriteLine($"Min = {min}");
		Console.WriteLine($"Max = {max}");
		Console.WriteLine($"Sum = {sum}");
		Console.WriteLine($"Average = {average}");
	}
}