using System;
using System.Collections.Generic;
using System.Linq;

public class FoldAndSum
{
	public static void Main()
	{
		var userInput = Console.ReadLine()
			.Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries)
			.Select(int.Parse)
			.ToArray();
		var k = userInput.Length / 4;
		List<int> firstRow = new List<int>();
		List<int> secondRow = new List<int>();
		for (int i = k - 1; i >= 0; i--)
		{
			firstRow.Add(userInput[i]);
		}
		for (int i = userInput.Length -1; i >= userInput.Length - 1 - k; i--)
		{
			firstRow.Add(userInput[i]);
		}
		for (int i = k; i < userInput.Length - k; i++)
		{
			secondRow.Add(userInput[i]);
		}
		List<int> sumOfTwoRows = new List<int>();
		for (int i = 0; i < secondRow.Count; i++)
		{
			sumOfTwoRows.Add(firstRow[i] + secondRow[i]);
		}
		Console.WriteLine(string.Join(" ", sumOfTwoRows));
	}
}