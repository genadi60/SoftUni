using System;
using System.Linq;

public class UpgradedMatcher
{
	public static void Main()
	{
		var products = Console.ReadLine()
			.Split(' ')
			.ToArray();
		var quantities = Console.ReadLine()
			.Split(' ')
			.Select(long.Parse)
			.ToList();
		while (quantities.Count < products.Length)
		{
			quantities.Add(0L);
		}
		var priceOfProducts = Console.ReadLine()
			.Split(' ')
			.Select(decimal.Parse)
			.ToArray();
		var userInput = Console.ReadLine()
			.Split(' ')
			.ToArray();
		while (!userInput[0].Equals("done"))
		{
			var index = Array.IndexOf(products, userInput[0]);
			var order = long.Parse(userInput[1]);
			if (order <= quantities[index])
			{
				Console.WriteLine($"{products[index]} x {order} costs {(decimal)(order * priceOfProducts[index]):F2}");
				var different = quantities[index] - order;
				quantities.RemoveAt(index);
				quantities.Insert(index, different);
			}
			else
			{
				Console.WriteLine($"We do not have enough {products[index]}");
			}
			userInput = Console.ReadLine()
				.Split(' ')
				.ToArray();
		}
	}
}