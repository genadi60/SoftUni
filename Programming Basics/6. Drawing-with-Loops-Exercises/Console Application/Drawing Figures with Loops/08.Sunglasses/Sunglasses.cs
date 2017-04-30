using System;

class Sunglasses
{
    static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        char asterisk = '*';
        char empty = ' ';
        char slash = '/';
        char col = '|';
        int f = 0;
        while (f < n)
        {
            DrawRow(asterisk, empty, slash, col, f, n);
            Console.WriteLine();
            f++;
        }
    }

    private static void DrawRow(char a, char b, char c, char d, int f, int n)
    {
        if(f == 0 || f == n - 1)
        {
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write(a);
            }
        }
        else
        {
            Console.Write(a);
            for (int i = 0; i < 2 * n - 2; i++)
            {
                Console.Write(c);
            }
            Console.Write(a);
        }
        for (int i = 0; i < n; i++)
        {
            if((n % 2 == 1 && f == n / 2) || (n % 2 == 0 && f == n / 2 - 1))
            {
                Console.Write(d);
            }
            else
            {
                Console.Write(b);
            }
        }
        if (f == 0 || f == n - 1)
        {
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write(a);
            }
        }
        else
        {
            Console.Write(a);
            for (int i = 0; i < 2 * n - 2; i++)
            {
                Console.Write(c);
            }
            Console.Write(a);
        }
    }
}