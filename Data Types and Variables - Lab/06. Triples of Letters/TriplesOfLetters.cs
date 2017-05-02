using System;

class TriplesOfLetters
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        for (char i = 'a'; i < 'a' + length; i++)
        {
            for (char j = 'a'; j < 'a' + length; j++)
            {
                for (char k = 'a'; k < 'a' + length; k++)
                {
                    Console.WriteLine($"{i}{j}{k}");
                }
            }
        }
    }
}