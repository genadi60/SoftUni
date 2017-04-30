using System;

class TriangleOf55Stars
{
    static void Main()
    {
        int count = 0;
        for (int i = 0; i < 55; i++)
        {
            for (int j = 0; j < i +1; j++)
            {
                Console.Write('*');
                count++;
            }
            Console.WriteLine();
            if(count == 55)
            {
                break;
            }
        }
    }
}