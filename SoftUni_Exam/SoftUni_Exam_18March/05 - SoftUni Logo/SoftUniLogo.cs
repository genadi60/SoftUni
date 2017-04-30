using System;

class SoftUniLogo
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char doth = '.';
        char care = '#';
        char row = '|';
        char eta = '@';
        int a = (12 * n - 6) / 2;
        int b = 1;
        while (a >= 0)
        {
            DrawTop(doth,care, a, b);
            a -= 3;
            b += 6;
        }
        a += 6;
        b -= 12;
        for (int i = 0; i < n - 1; i++)
        {
            DrawMiddle(doth, care, row, a, b);
            a += 3;
            b -= 6;
        }
        a -= 3;
        b += 6;
        for (int i = 0; i < n - 1; i++)
        {
            if (i == n - 2)
            {
                row = '@';
            }
            DrawMiddle(doth, care, row, a, b);
            
        }

    }

    static void DrawMiddle(char doth, char care, char row, int a, int b)
    {
        Console.Write(row);
        for (int i = 0; i < a - 1; i++)
        {
            Console.Write(doth);
        }
        for (int i = 0; i < b; i++)
        {
            Console.Write(care);
        }
        for (int i = 0; i < a; i++)
        {
            Console.Write(doth);
        }
        Console.WriteLine();
    }

    static void DrawTop(char doth, char care, int a, int b)
    {
        for (int i = 0; i < a; i++)
        {
            Console.Write(doth);
        }
        for (int i = 0; i < b; i++)
        {
            Console.Write(care);
        }
        for (int i = 0; i < a; i++)
        {
            Console.Write(doth);
        }
        Console.WriteLine();
    }
}