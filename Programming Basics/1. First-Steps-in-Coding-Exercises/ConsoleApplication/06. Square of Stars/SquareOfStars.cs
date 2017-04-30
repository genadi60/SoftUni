using System;

class SquareOfStars
{
    static void Main()
    {
        var side = int.Parse(Console.ReadLine());
        var count = side -1;
        char asterisks = '*';
        char space = ' ';
        while(count > -1)
        {
            DrawRectangle(asterisks, space, side, count);
            count--;
        }
    }

    static void DrawRectangle(char a, char b, int c, int d)
    {
        Console.Write(a);
        for (int i = 0; i < c - 2; i++)
        {
           if(d != 0 && d != c -1 )
            {
                Console.Write(b);
            }
            else
            {
                Console.Write(a);
            }
        }
        Console.Write(a);
        Console.WriteLine();
    }
}