using System;

class House
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char asterisk = '*';
        char dash = '-';
        char col = '|';
        int f = 2 - n % 2;
        int k = (n - f) / 2;
        while (k > -1)
        {
            DrawRow(asterisk, dash, f, k);
            Console.WriteLine();
            f += 2;
            k--;
        }
        f = n - 2;
        k = 1;
        while (n / 2 > 0)
        {
            DrawRow(asterisk, col, f, k);
            Console.WriteLine();
            n -= 2;
        }
    }

    private static void DrawRow(char a, char b, int f, int k)
    {
        for (int i = 0; i < k; i++)
        {
            Console.Write(b);
        }
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