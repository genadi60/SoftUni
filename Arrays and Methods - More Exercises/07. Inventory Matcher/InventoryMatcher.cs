using System;
using System.Linq;

public class InventoryMatcher
{
	public static void Main()
	{
		var products = Console.ReadLine()
			.Split(' ')
			.ToArray();
		var quantities = Console.ReadLine()
			.Split(' ')
			.Select(long.Parse)
			.ToArray();
		var priceOfProducts = Console.ReadLine()
			.Split(' ')
			.Select(decimal.Parse)
			.ToArray();
		var userInput =Console.ReadLine();
		while (!userInput.Equals("done"))
		{
			var index = Array.IndexOf(products, userInput);
			Console.WriteLine($"{userInput} costs: {priceOfProducts[index]}; Available quantity: {quantities[index]}");
			userInput = Console.ReadLine();
		}
	}
}