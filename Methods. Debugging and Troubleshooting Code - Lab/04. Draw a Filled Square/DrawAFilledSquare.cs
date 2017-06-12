using System;

public class DrawAFilledSquare
{
	public static void Main()
	{
		var sizeOfSquare = int.Parse(Console.ReadLine());
		DrawFilledSquare(sizeOfSquare);
	}

	static void DrawFilledSquare(int size)
	{
		for (int i = 0; i < size * 2; i++)
		{
			Console.Write('-');
		}
		Console.WriteLine();
		for (int i = 0; i < size - 2; i++)
		{
			Console.Write('-');
			for (int j = 1; j < size; j++)
			{
				Console.Write("\\/");
			}
			Console.WriteLine('-');
		}
		for (int i = 0; i < size * 2; i++)
		{
			Console.Write('-');
		}
		Console.WriteLine();
	}
}