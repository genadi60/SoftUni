using System;
using System.Collections.Generic;
using System.Linq;

public class PizzaIngredients
{
	public static void Main()
	{
		var ingredients = Console.ReadLine()
			.Split(' ')
			.ToArray();
		var ingrLength = int.Parse(Console.ReadLine());
		var ingredientsCount = 10;
		var count = 0;
		List<string> pizzaIngredients = new List<string>();
		for (int i = 0; i < ingredients.Length; i++)
		{
			if (ingredients[i].Length == ingrLength)
			{
				Console.WriteLine($"Adding {ingredients[i]}.");
				pizzaIngredients.Add(ingredients[i]);
				count++;
			}
			if (count == ingredientsCount)
			{
				break;
			}
		}
		Console.WriteLine($"Made pizza with total of {count} ingredients.");
		Console.WriteLine($"The ingredients are: {string.Join(", ", pizzaIngredients)}.");
	}
}