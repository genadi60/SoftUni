using System;

class Axe
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char dash = '-';
        char asterisk = '*';
        int a = 0;
        int b = 2 * n - 2;
        for (int i = 0; i < n; i++)
        {
            DrawTop(dash, asterisk, n, a, b);
            a++;
            b--;
            Console.WriteLine();
        }
        a--;
        b++;

        for (int i = 0; i < n / 2; i++)
        {
            DrawMiddle(dash, asterisk, n, a, b);
            Console.WriteLine();
        }
        for (int j = 0; j < n / 2; j++)
        {
            DrawBottom(dash, asterisk, n, a, b, j);
            a += 2;
            b--;
            Console.WriteLine();
        }
        
    }

    static void DrawBottom(char dash, char asterisk, int n, int a, int b, int j)
    {
        for (int i = 0; i < 5 * n - a - b - 2; i++)
        {
            Console.Write(dash);
        }
        Console.Write(asterisk);
        for (int i = 0; i < a; i++)
        {
            if (j != n / 2 - 1)
            {
                Console.Write(dash);
            }
            else
            {
                Console.Write(asterisk);
            }
            
        }
        Console.Write(asterisk);
        for (int i = 0; i < b; i++)
        {
            Console.Write(dash);
        }
    }

    static void DrawMiddle(char dash, char asterisk, int n, int a, int b)
    {
        for (int i = 0; i < 3 * n; i++)
        {
            Console.Write(asterisk);
        }
        Console.Write(asterisk);
        for (int i = 0; i < a; i++)
        {
            Console.Write(dash);
        }
        Console.Write(asterisk);
        for (int i = 0; i < b; i++)
        {
            Console.Write(dash);
        }
    }

    static void DrawTop(char dash, char asterisk, int n, int a, int b)
    {
        for (int i = 0; i < 3 * n; i++)
        {
            Console.Write(dash);
        }
        Console.Write(asterisk);
        for (int i = 0; i < a; i++)
        {
            Console.Write(dash);
        }
        Console.Write(asterisk);
        for (int i = 0; i < b; i++)
        {
            Console.Write(dash);
        }
    }
}