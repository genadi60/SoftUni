using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class RageQuit
{
	public static void Main()
	{
		var outputList = new List<string>();
		var sequence = string.Empty;
		var pattern = @"\d+";
		var regex = new Regex(pattern);
		var input = Console.ReadLine().ToUpper();
		//var symbols = input
		//	.Select(x => (char)x)
		//	.Where(x => !Char.IsDigit(x) && x != ' ')
		//	.Distinct()
		//	.ToArray();
		var findedSequence = regex.Match(input);
		while (findedSequence.Success && input.Length > 0)
		{
			sequence = input.Substring(0, findedSequence.Index);
			input = input.Substring(findedSequence.Index + findedSequence.Value.Length);
			var loop = int.Parse(findedSequence.Value);
			for (int i = 0; i < loop; i++)
			{
				outputList.Add(sequence);
			}
			findedSequence = regex.Match(input);
		}
		var output = String.Join("", outputList);
		Console.WriteLine($"Unique symbols used: {output.Distinct().Count()}");
		Console.WriteLine(output);
	}
}