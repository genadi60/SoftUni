using System;
using System.Linq;

public class SafeManipulation
{
	public static void Main()
	{
		var inputStrings = Console.ReadLine()
			.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
			.ToList();
		//var numberOfCommands = int.Parse(Console.ReadLine());
		var commands = Console.ReadLine()
			.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
			.ToArray();
		while (!commands[0].Equals("END"))
		{
			switch (commands[0])
			{
				case "Distinct":
					inputStrings = inputStrings.Distinct().ToList();
					break;
				case "Reverse":
					inputStrings.Reverse();
					break;
				case "Replace":
					var i = int.Parse(commands[1]);
					if (i < 0 || i > inputStrings.Count - 1)
					{
						Console.WriteLine("Invalid input!");
						break;
					}
					else
					{
						inputStrings.RemoveAt(i);
						inputStrings.Insert(i, commands[2]);
					}
					break;
				default:
					Console.WriteLine("Invalid input!");
					break;
			}
			commands = Console.ReadLine()
				.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
				.ToArray();
		}

		Console.WriteLine(string.Join(", ", inputStrings));
	}
}