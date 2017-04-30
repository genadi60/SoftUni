using System;

class TriangleOfDollars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int k = i;
            Console.Write("$");
            while(k > 0)
            {
                Console.Write(" $");
                k--;
            }
            Console.WriteLine();
        }
    }
}