using System;

public class CompareCharArrays
{
	public static void Main()
	{
		var firstArray = Console.ReadLine()
			.Split(new[] { " " },StringSplitOptions.RemoveEmptyEntries);
		var secondArray = Console.ReadLine()
			.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
		var firstString = string.Join("", firstArray);
		var secondString = string.Join("", secondArray);
var comp = string.Compare(firstString, secondString);
		if (comp <= 0)
		{
			Console.WriteLine(firstString);
			Console.WriteLine(secondString);
		}
		else
		{
			Console.WriteLine(secondString);
			Console.WriteLine(firstString);
		}
	}
}