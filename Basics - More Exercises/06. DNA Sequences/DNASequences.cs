using System;

public class DNASequences
{
    public static void Main()
    {
        var matchSum = int.Parse(Console.ReadLine());
        var printedString = string.Empty;
        var number = string.Empty;
        char parantese = ' ';
        var count = 0;
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                for (int k = 1; k <= 4; k++)
                {
                    if ((i + j + k) < matchSum )
                    {
                        parantese = 'X';
                    }
                    else
                    {
                        parantese = 'O';
                    }
                    number = (i * 100 + j * 10 + k).ToString();
                    
                    foreach (var digit in number)
                    {
                        switch (digit)
                        {
                            case '1':
                                printedString += 'A';
                                break;
                            case '2':
                                printedString += 'C';
                                break;
                            case '3':
                                printedString += 'G';
                                break;
                            case '4':
                                printedString += 'T';
                                break;
                            default:
                                break;
                        }
                    }
                    Console.Write(parantese + printedString + parantese + " ");
                    printedString = string.Empty;
                    count++;
                    if (count == 4)
                    {
                        Console.WriteLine();
                        count = 0;
                    }
                }
            }
        }
    }
}