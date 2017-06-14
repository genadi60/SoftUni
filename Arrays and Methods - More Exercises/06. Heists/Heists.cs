using System;
using System.Linq;

public class Heists
{
	public static void Main()
	{
		var prices = Console.ReadLine()
			.Split(' ')
			.Select(int.Parse)
			.ToArray();
		var jewelPrice = prices[0];
		var goldPrice = prices[1];
		char jewel = '%';
		char gold = '$';
		var heists = Console.ReadLine()
			.Split(' ')
			.ToArray();
		var sumLootMoney = 0L;
		var sumHeistsExpenses = 0L;
		while (!heists[0].Equals("Jail") && !heists[1].Equals("Time"))
		{
			var loot = heists[0];
			var heistExpenses = int.Parse(heists[1]);
			sumHeistsExpenses += heistExpenses;
			foreach (var item in loot)
			{
				if (item == jewel)
				{
					sumLootMoney += jewelPrice;
				}
				if (item == gold)
				{
					sumLootMoney += goldPrice;
				}
			}
			heists = Console.ReadLine()
				.Split(' ')
				.ToArray();
		}
		if (sumLootMoney >= sumHeistsExpenses)
		{
			Console.WriteLine($"Heists will continue. Total earnings: {sumLootMoney - sumHeistsExpenses}.");
		}
		else
		{
			Console.WriteLine($"Have to find another job. Lost: {sumHeistsExpenses - sumLootMoney}.");
		}
	}
}