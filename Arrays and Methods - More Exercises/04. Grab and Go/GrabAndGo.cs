using System;
using System.Linq;
using System.Collections.Generic;

public class GrabAndGo
{
	public static void Main()
	{
		var numbers = Console.ReadLine()
			.Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries)
			.Select(int.Parse)
			.Reverse()
			.ToArray();
		
		var numberToFind = int.Parse(Console.ReadLine());
		bool finded = false;
		var sum = 0L;
		for (int i = 0; i < numbers.Length; i++)
		{
			if (finded)
			{
				sum += numbers[i];
			}
			if (numbers[i] == numberToFind)
			{
				finded = true;
			}
		}
		if (finded)
		{
			Console.WriteLine(sum);
		}
		else
		{
			Console.WriteLine("No occurrences were found!");
		}
	}
}