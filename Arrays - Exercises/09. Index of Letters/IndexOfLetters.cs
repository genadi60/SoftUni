using System;

public class IndexOfLetters
{
	public static void Main()
	{
		var characters = Console.ReadLine().ToLower();
		foreach (var character in characters)
		{
			Console.WriteLine($"{character} -> {character - 'a'}");
		}
	}
}