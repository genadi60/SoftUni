using System;
using System.Collections.Generic;
using System.Linq;

public class AppendLists
{
	public static void Main()
	{
		var inputStrings = Console.ReadLine()
			.Split('|')
			.Reverse()
			.ToList();
		var outputString = string.Join(" ", inputStrings);
		var outputList = outputString
			.Split(new []{" "}, StringSplitOptions.RemoveEmptyEntries)
			.ToList();
		
		Console.WriteLine(string.Join(" ", outputList));
	}
}