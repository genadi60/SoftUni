using System;

class SquareOfStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.Write("*");
            for (int j = 1; j < n; j++)
            {
                Console.Write(" *");
            }
            Console.WriteLine();
        }
    }
}