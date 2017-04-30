using System;

class Illuminati
{
    static void Main()
    {
        string userInput = Console.ReadLine().ToUpper();
        int result = 0;
        int count = 0;
        foreach(char item in userInput)
        {
            switch (item)
            {
                case 'A':
                    result += 65;
                    count++;
                    break;
                case 'E':
                    result += 69;
                    count++;
                    break;
                case 'I':
                    result += 73;
                    count++;
                    break;
                case 'O':
                    result += 79;
                    count++;
                    break;
                case 'U':
                    result += 85;
                    count++;
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine(count);
        Console.WriteLine(result);
    }
}