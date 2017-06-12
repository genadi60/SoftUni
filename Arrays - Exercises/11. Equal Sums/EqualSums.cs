using System;
using System.Linq;

public class EqualSums
{
	public static void Main()
	{
		var numbers = Console.ReadLine()
			.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
			.Select(double.Parse)
			.ToArray();
		
		var leftSum = 0.0;
		var rightSum = 0.0;
		for (int i = 0; i < numbers.Length; i++)
		{
			leftSum = 0.0;
			rightSum = 0.0;
			for (int j = 0; j < i; j++)
			{
				leftSum += numbers[j];
			}
			for (int k = i + 1; k < numbers.Length; k++)
			{
				rightSum += numbers[k];
			}
			if (leftSum == rightSum)
			{
				Console.WriteLine(i);
				break;
			}
		}
		if (leftSum != rightSum)
		{
			Console.WriteLine("no");
		}
	}
}