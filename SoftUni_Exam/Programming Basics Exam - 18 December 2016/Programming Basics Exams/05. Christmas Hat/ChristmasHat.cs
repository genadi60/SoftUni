using System;

class ChristmasHat
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char doth = '.';
        char asterisk = '*';
        char slash = '/';
        char leftSlash = '\\';
        char row = '|';
        char dash = '-';
        int a = 2 * n - 1;
        int b = 0;
        DrawHatTop(doth, slash, row, leftSlash, a);
        while (b < 2 * n)
        {
            DrawHat(doth, asterisk, dash, a, b);
            b++;
            a--;
        }
        DrawHatDown(doth, asterisk, n);
    }

    static void DrawHatDown(char doth, char asterisk, int n)
    {
        bool a = true;
        for (int i = 0; i < 4 * n + 1; i++)
        {
            Console.Write(asterisk);
        }
        Console.WriteLine();
        for (int i = 0; i < 4 * n + 1; i++)
        {
            Console.Write(a?asterisk:doth);
            a = !a;
        }
        Console.WriteLine();
        for (int i = 0; i < 4 * n + 1; i++)
        {
            Console.Write(asterisk);
        }
        Console.WriteLine();
    }

    static void DrawHatTop(char doth, char slash, char row, char leftSlash, int a)
    {
        char b = slash;
        char c = leftSlash;
        for (int j = 0; j <= 1; j++)
        {
            for (int i = 0; i < a; i++)
            {
                Console.Write(doth);
            }
            Console.Write(b);
            Console.Write(row);
            Console.Write(c);
            for (int i = 0; i < a; i++)
            {
                Console.Write(doth);
            }
            Console.WriteLine();
            b = leftSlash;
            c = slash;
        }
        
    }

    static void DrawHat(char doth, char asterisk, char dash, int a, int b)
    {
        for (int i = 0; i < a; i++)
        {
            Console.Write(doth);
        }
        Console.Write(asterisk);
        for (int i = 0; i < b; i++)
        {
            Console.Write(dash);
        }
        Console.Write(asterisk);
        for (int i = 0; i < b; i++)
        {
            Console.Write(dash);
        }
        Console.Write(asterisk);
        for (int i = 0; i < a; i++)
        {
            Console.Write(doth);
        }
        Console.WriteLine();
    }
}