using System;

class SquareFrame
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char plus = '+';
        char minus = '-';
        char col = '|';
        char empty = ' ';
        int f = 0;
        while(f < n)
        {
            DrawRow(plus, minus, col, empty, f, n);
            Console.WriteLine();
            f++;
        }
        
    }

    private static void DrawRow(char a, char b, char c, char d, int f, int n)
    {
        if (f == 0 || f == n - 1)
        {
            Console.Write(a);
            for (int i = 1; i < n - 1; i++)
            {
                Console.Write(d);
                Console.Write(b);
            }
            Console.Write(d);
            Console.Write(a);
        }
        else
        {
            Console.Write(c);
            for (int i = 1; i < n - 1; i++)
            {
                Console.Write(d);
                Console.Write(b);
            }
            Console.Write(d);
            Console.Write(c);
        }
    }
}