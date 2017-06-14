using System;
using System.Linq;

public class JumpAround
{
	public static void Main()
	{
		var arr = Console.ReadLine()
			.Split(' ')
			.Select(int.Parse)
			.ToArray();
		var step = arr[0];
		var index = 0;
		var sum = arr[index];
		while ((index + step) < arr.Length || (index - step) >= 0)
		{
			if ((index + step) < arr.Length)
			{
				index += step;
				step = arr[index];
				sum += step;
			}
			else if ((index - step) >= 0)
			{
				index -= step;
				step = arr[index];
				sum += step;
			}
		}
		Console.WriteLine(sum);
	}
}