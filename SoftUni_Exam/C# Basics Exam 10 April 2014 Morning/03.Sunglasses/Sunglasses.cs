using System;

class Sunglasses
{
    static void Main()
    {
        int heightGlasses = int.Parse(Console.ReadLine());
        char asterisk = '*';
        char lashD = '/';
        char dash = '|';
        char space = ' ';
        int row = 0;
        while (row < heightGlasses)
        {
            DrawGlasses(asterisk, lashD, dash, space, row, heightGlasses);
            row++;
        }

    }

    static void DrawGlasses(char asterisk, char lashD, char dash, char space, int row, int heightGlasses)
    {
        if (row == 0 || row == heightGlasses - 1)
        {
            for (int i = 0; i < 2 * heightGlasses; i++)
            {
                Console.Write(asterisk);
            }
        }
        else
        {
            Console.Write(asterisk);
            for (int i = 0; i < 2 * heightGlasses - 2; i++)
            {
                Console.Write(lashD);
            }
            Console.Write(asterisk);
        }
        for (int i = 0; i < heightGlasses; i++)
        {
            if (row != heightGlasses / 2)
            {
                Console.Write(space);
            }
            else
            {
                Console.Write(dash);
            }

        }
        if (row == 0 || row == heightGlasses - 1)
        {
            for (int i = 0; i < 2 * heightGlasses; i++)
            {
                Console.Write(asterisk);
            }
        }
        else
        {
            Console.Write(asterisk);
            for (int i = 0; i < 2 * heightGlasses - 2; i++)
            {
                Console.Write(lashD);
            }
            Console.Write(asterisk);
        }
        Console.WriteLine();
    }
}