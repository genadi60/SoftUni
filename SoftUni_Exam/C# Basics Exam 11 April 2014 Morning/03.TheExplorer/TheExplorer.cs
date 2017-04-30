using System;

class TheExplorer
{
    static void Main()
    {
        int userInput = int.Parse(Console.ReadLine());
        char dash = '-';
        char asterisk = '*';
        int side = userInput/2;
        int mid = -1;
        while (side >= 0)
        {
            Draw(dash, asterisk, side, mid, userInput);
            side--;
            mid += 2;
        }
        side = 1;
        mid = userInput - 4;
        while(side <= userInput / 2)
        {
            Draw(dash, asterisk, side, mid, userInput);
            side++;
            mid -= 2;
        }
    }

    static void Draw(char a, char b, int c, int d, int f)
    {
        for (int i = 0; i < c; i++)
        {
            Console.Write(a);
        }
        Console.Write(b);
        if(c < f/2)
        {
            for (int i = 0; i < d; i++)
            {
                Console.Write(a);
            }
            Console.Write(b);
        }
        
        for (int i = 0; i < c; i++)
        {
            Console.Write(a);
        }
        Console.WriteLine();
    }
}