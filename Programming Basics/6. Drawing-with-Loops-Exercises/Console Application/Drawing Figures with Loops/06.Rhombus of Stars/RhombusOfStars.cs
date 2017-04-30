using System;

class RhombusOfStars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char asterisk = '*';
        char empty = ' ';
        int f = 1;
        int k = n;
        while (k > 0)
        {
            DrawRow(asterisk, empty, f, k);
            Console.WriteLine();
            f++;
            k--;
        }
        f -= 2;
        k += 2;
        while(f > 0)
        {
            DrawRow(asterisk, empty, f, k);
            Console.WriteLine();
            f--;
            k++;
        }

    }

    private static void DrawRow(char a, char b, int f, int k)
    {
        for (int i = 0; i < k - 1; i++)
        {
            Console.Write(b);
        }
        for (int i = 0; i < f; i++)
        {
            if (i == 0)
            {
                Console.Write(a);
            }
            else
            {
                Console.Write(b);
                Console.Write(a);
            }
        }
    }
}