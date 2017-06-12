using System;

public class PrintingTriangle
{
	public static void Main()
	{
		var sizeOfTriangle = int.Parse(Console.ReadLine());
		PrintinTriangle(sizeOfTriangle);
	}

	private static void PrintinTriangle(int size)
	{
		for (int i = 1; i <= size; i++)
		{
			PrintIntervalOfNumbers(1, i);
		}
		for (int i = size - 1; i > 0; i--)
		{
			PrintIntervalOfNumbers(1, i);
		}
	}

	static void PrintIntervalOfNumbers(int start, int end)
	{
		for (int i = start; i <= end; i++)
		{
			Console.Write($"{i} ");
		}
		Console.WriteLine();
	}
}