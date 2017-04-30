using System;

class ChristmasTree
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());
        char asterisk = '*';
        char empty = ' ';
        char col = '|';
        int f = 0;
        int k = n;
        while (k >= 0)
        {
            DrawRow(asterisk, empty, col, f, k);
            Console.WriteLine();
            f++;
            k--;
        }
    }

    private static void DrawRow(char a, char b, char c, int f, int k)
    {
        for (int i = 0; i < k; i++)
        {
            Console.Write(b);
        }
        for (int i = 0; i < f; i++)
        {
            Console.Write(a);
        }
        Console.Write(b);
        Console.Write(c);
        Console.Write(b);
        for (int i = 0; i < f; i++)
        {
            Console.Write(a);
        }
        for (int i = 0; i < k; i++)
        {
            Console.Write(b);
        }
    }
}

