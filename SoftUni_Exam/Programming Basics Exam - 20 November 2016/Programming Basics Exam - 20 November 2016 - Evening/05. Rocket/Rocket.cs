using System;

class Rocket
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char doth = '.';
        char empty = ' ';
        char slash = '/';
        char leftSlash = '\\';
        char row = '|';
        char asterisk = '*';
        int a = n + n / 2 - 1;
        int b = 0;
        while (a >= n / 2)
        {
            DrawTop(doth, empty, slash, leftSlash, a, b);
            b += 2;
            a--;
            Console.WriteLine();
        }
        a = 0;
        while (a <= 2 * n)
        {
            DrawBody(doth, row, asterisk, leftSlash, n, a);
            a++;
            Console.WriteLine();
        }
        a = n / 2;
        b = 2 * n - 2;
        while (a >= 1)
        {
            DrawDown(doth, asterisk, slash, leftSlash, a, b);
            a--;
            b += 2;
            Console.WriteLine();
        }
    }

    static void DrawDown(char doth, char asterisk, char slash, char leftSlash, int a, int b)
    {
        for (int i = 0; i < a; i++)
        {
            Console.Write(doth);
        }
        Console.Write(slash);
        for (int i = 0; i < b; i++)
        {
            Console.Write(asterisk);
        }
        Console.Write(leftSlash);
        for (int i = 0; i < a; i++)
        {
            Console.Write(doth);
        }
    }

    static void DrawBody(char doth, char row, char asterisk, char leftSlash, int n, int a)
    {
        if (a == 0)
        {
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(doth);
            }
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write(asterisk);
            }
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(doth);
            }
        }
        else
        {
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(doth);
            }
            Console.Write(row);
            for (int i = 0; i < 2 * n - 2; i++)
            {
                Console.Write(leftSlash);
            }
            Console.Write(row);
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(doth);
            }
        }
    }

    static void DrawTop(char doth, char empty, char slash, char leftSlash, int a, int b)
    {
        for (int i = 0; i < a; i++)
        {
            Console.Write(doth);
        }
        Console.Write(slash);
        for (int i = 0; i < b; i++)
        {
            Console.Write(empty);
        }
        Console.Write(leftSlash);
        for (int i = 0; i < a; i++)
        {
            Console.Write(doth);
        }
    }
}