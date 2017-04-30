using System;

class DrawFigure
{
    static void Main()
    {
        int userInput = int.Parse(Console.ReadLine());
        char asterisk = '*';
        char doth = '.';
        int a = userInput;
        int b = 0;
        while (a > 1)
        {
            DrawTriangle(a, b, asterisk, doth);
            a -= 2;
            b++;
        }
        while (a < userInput + 1)
        {
            DrawTriangle(a, b, asterisk, doth);
            a += 2;
            b--;
        }

    }

    static void DrawTriangle(int a, int b, char c, char d)
    {
        for (int i = 0; i < b; i++)
        {
            Console.Write(d);
        }
        for (int i = 0; i < a; i++)
        {
            Console.Write(c);
        }
        for (int i = 0; i < b; i++)
        {
            Console.Write(d);
        }
        Console.WriteLine();
    }
}