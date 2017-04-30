using System;

class NewHouse
{
    static void Main()
    {
        int userInput = int.Parse(Console.ReadLine());
        char dash = '-';
        char asterisk = '*';
        char pipe = '|';
        int c = userInput / 2;
        int d = 1;
        while(c > -1)
        {
            DrawRoof(dash, asterisk, c, d);
            c--;
            d += 2;
        }
        d = 0;
        while(d < userInput)
        {
            DrawWall(pipe, asterisk, userInput);
            d++;
        }
    }

    static void DrawWall(char a, char b, int c)
    {
        Console.Write(a);
        for (int i = 0; i < c - 2; i++)
        {
            Console.Write(b);
        }
        Console.Write(a);
        Console.WriteLine();
    }

    static void DrawRoof(char a, char b, int c, int d)
    {
        for (int i = 0; i < c; i++)
        {
            Console.Write(a);
        }
        for (int i = 0; i < d; i++)
        {
            Console.Write(b);
        }
        for (int i = 0; i < c; i++)
        {
            Console.Write(a);
        }
        Console.WriteLine();
    }
}