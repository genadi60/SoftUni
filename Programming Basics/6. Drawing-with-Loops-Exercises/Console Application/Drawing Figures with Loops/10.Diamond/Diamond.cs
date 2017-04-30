using System;

class Diamond
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char asterisk = '*';
        char dash = '-';
        int f = 2 - n % 2;
        int k = (n - f) / 2;
        while (k > -1)
        {
            DrawRow(asterisk, dash, f, k);
            Console.WriteLine();
            f += 2;
            k--;
        }
        f -= 4;
        k += 2;
        while (f > 0)
        {
            DrawRow(asterisk, dash, f, k);
            Console.WriteLine();
            f -= 2;
            k++;
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
            if(i == 0 || i == f - 1)
            {
                Console.Write(a);
            }
            else
            {
                Console.Write(b);
            }
        }
        for (int i = 0; i < k; i++)
        {
            Console.Write(b);
        }
    }
}