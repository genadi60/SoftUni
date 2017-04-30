using System;

class VowelsSum
{
    static void Main()
    {
        string userInput = Console.ReadLine().ToLower();
        int sum = 0;
        foreach(char i in userInput)
        {
            switch (i)
            {
                case 'a':
                    sum++;
                    break;
                case 'e':
                    sum += 2;
                    break;
                case 'i':
                    sum += 3;
                    break;
                case 'o':
                    sum += 4;
                    break;
                case 'u':
                    sum += 5;
                    break;
                default:
                    break;   
            }
        }
        Console.WriteLine(sum);
    }
}