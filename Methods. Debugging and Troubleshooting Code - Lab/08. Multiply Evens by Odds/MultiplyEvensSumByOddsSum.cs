using System;

public class MultiplyEvensSumByOddsSum
{
	public static void Main()
	{
		var inputNumber = Math.Abs(int.Parse(Console.ReadLine()));
		var sumOdds = 0;
		var sumEvens = 0;
		while (inputNumber > 0)
		{
			var digit = inputNumber % 10;
			if (digit % 2 == 0)
			{
				sumEvens += digit;
			}
			else
			{
				sumOdds += digit;
			}
			inputNumber /= 10;
		}
		Console.WriteLine(sumOdds * sumEvens);
	}
}