using System;

class Fox
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char asterisk = '*';
        char leftSlash = '\\';
        char slash = '/';
        char dash = '-';
        char row = '|';
        int a = 1;
        int b = 2 * n - 1;
        while (b > 0)
        {
            DrawTop(asterisk, leftSlash, slash, dash, a, b);
            a++;
            b -= 2;
            Console.WriteLine();
        }
        a = (n - 1) / 2;
        b = n;
        int count = 1;
        while (count <= n / 3)
        {
            DrawMiddle(asterisk, leftSlash, slash, row, a, b);
            a++;
            b -= 2;
            count++;
            Console.WriteLine();
        }
        a = 1;
        b = 2 * n - 1;
        while (b > 0)
        {
            DrawDown(asterisk, leftSlash, slash, dash, a, b);
            a++;
            b -= 2;
            Console.WriteLine();
        }

    }

    static void DrawDown(char asterisk, char leftSlash, char slash, char dash, int a, int b)
    {
        for (int i = 0; i < a; i++)
        {
            Console.Write(dash);
        }
        Console.Write(leftSlash);
        for (int i = 0; i < b; i++)
        {
            Console.Write(asterisk);
        }
        Console.Write(slash);
        for (int i = 0; i < a; i++)
        {
            Console.Write(dash);
        }
    }

    static void DrawMiddle(char asterisk, char leftSlash, char slash, char row, int a, int b)
    {
        Console.Write(row);
        for (int i = 0; i < a; i++)
        {
            Console.Write(asterisk);
        }
        Console.Write(leftSlash);
        for (int i = 0; i < b; i++)
        {
            Console.Write(asterisk);
        }
        Console.Write(slash);
        for (int i = 0; i < a; i++)
        {
            Console.Write(asterisk);
        }
        Console.Write(row);
    }

    static void DrawTop(char asterisk, char leftSlash, char slash, char dash, int a, int b)
    {
        for (int i = 0; i < a; i++)
        {
            Console.Write(asterisk);
        }
        Console.Write(leftSlash);
        for (int i = 0; i < b; i++)
        {
            Console.Write(dash);
        }
        Console.Write(slash);
        for (int i = 0; i < a; i++)
        {
            Console.Write(asterisk);
        }
    }
}