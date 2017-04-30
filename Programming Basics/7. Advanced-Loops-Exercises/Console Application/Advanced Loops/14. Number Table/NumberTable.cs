using System;

class NumberTable
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int j = 0; j < n; j++)
        {
            for (int i = 1; i <= n - j; i++)
            {
                Console.Write((i + j) + " ");
            }
            for (int i = 1; i <= j ; i++)
            {
                Console.Write((n - i) + " ");
            }
            Console.WriteLine();
        }
    }
}