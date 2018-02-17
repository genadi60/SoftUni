using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

public class RageQuit
{
	public static void Main()
	{
		var pattern = @"(?<group>(?<replacement>\D+)(?<digit>\d+))";
		var regex = new Regex(pattern);
		var input = Console.ReadLine().ToUpper();
		var output = new StringBuilder();
		var findedSequence = regex.Matches(input);
		foreach (Match match in findedSequence)
		{
			var count = int.Parse(match.Groups["digit"].Value);
			var matchedString = match.Groups["replacement"].Value;
			for (int i = 0; i < count; i++)
			{
				output.Append(matchedString);
			}
		}
		Console.WriteLine($"Unique symbols used: {output.ToString().Distinct().Count()}");
		Console.WriteLine(output);
	}
}