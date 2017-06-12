using System;

public class HelloName
{
	public static void Main()
	{
		var name = Console.ReadLine();
		PrintGreetingWithName(name);
	}

	static void PrintGreetingWithName(string name)
	{
		Console.WriteLine($"Hello, {name}!");
	}
}