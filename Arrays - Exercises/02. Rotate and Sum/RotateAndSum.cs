using System;
using System.Linq;

public class RotateAndSum
{
	public static void Main()
	{
		long[] numbers = Console.ReadLine()
			.Split(new []{' '},StringSplitOptions.RemoveEmptyEntries)
			.Select(long.Parse)
			.ToArray();
		var rotate = int.Parse(Console.ReadLine());
		var fullRotate = rotate / numbers.Length;
		
		var resultSum = new long[numbers.Length];
		var partialRotate = rotate % numbers.Length;
		for (int i = 1; i <= partialRotate; i++)
		{
			var temp = numbers[numbers.Length - 1];
			for (int j = 0; j < numbers.Length - 1; j++)
			{
				numbers[numbers.Length - 1 -j] = numbers[numbers.Length - 2 - j];
				resultSum[numbers.Length - 1 - j] += numbers[numbers.Length - j - 1];
			}
			numbers[0] = temp;
			resultSum[0] += temp;
		}
		var sum = 0L;
		if (fullRotate != 0)
		{
			for (int i = 0; i < numbers.Length; i++)
			{
				sum += numbers[i];
			}
			for (int i = 0; i < numbers.Length; i++)
			{
				resultSum[i] += fullRotate * sum;
			}
		}
		Console.WriteLine(string.Join(" ", resultSum));
	}
}