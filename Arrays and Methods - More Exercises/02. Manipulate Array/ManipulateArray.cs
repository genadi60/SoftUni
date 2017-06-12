using System;
using System.Linq;

public class ManipulateArray
{
	public static void Main()
	{
		var inputStrings = Console.ReadLine()
			.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
			.ToList();
		var numberOfCommands = int.Parse(Console.ReadLine());
		while(numberOfCommands > 0)
		{
			var commands = Console.ReadLine()
				.Split(new[] {" "},StringSplitOptions.RemoveEmptyEntries)
				.ToArray();
			if (commands[0].Equals("Distinct"))
			{
				inputStrings = inputStrings.Distinct().ToList();
			}
			else if (commands[0].Equals("Reverse"))
			{
				inputStrings.Reverse();
			}
			else if (commands[0].Equals("Replace"))
			{
				var i = int.Parse(commands[1]);
				inputStrings.RemoveAt(i);
				inputStrings.Insert(i, commands[2]);
			}
			numberOfCommands--;
		}

		Console.WriteLine(string.Join(", ", inputStrings));
	}
}