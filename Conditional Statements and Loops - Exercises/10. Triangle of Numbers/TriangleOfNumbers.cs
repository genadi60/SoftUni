using System;

class TriangleOfNumbers
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (j < (i -1))
                {
                    Console.Write(i + " ");
                }
                else
                {
                    Console.Write(i);
                }
            }
            Console.WriteLine();
        }
    }
}