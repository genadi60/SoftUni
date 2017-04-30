using System;
using System.Collections.Generic;

class ProgrammerDNA
{
    static void Main()
    {
        int dnaLength = int.Parse(Console.ReadLine());
        string begin = Console.ReadLine();
        begin = begin.ToUpper();
        char element = Convert.ToChar(begin);
        int diamondSize = 7;
        List<char> sec = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G' };
        int index = sec.IndexOf(element);
        
        while(dnaLength > 0)
        {
            for (int row = 0; row < diamondSize; row++)
            {
                if (dnaLength > 0)
                {
                    if (row < 4)
                    {
                        for (int col = 0; col < diamondSize; col++)
                        {
                            if ((row + col) <= 2 || (col - row) >= 4)
                            {
                                Console.Write('.');
                            }
                            else
                            {
                                Console.Write(sec[index]);
                                index++;
                                if (index == sec.Count)
                                {
                                    index = 0;
                                }
                            }
                        }

                        Console.WriteLine();
                    }
                    else
                    {
                        for (int col = 0; col < diamondSize; col++)
                        {
                            if ((row - col) >= 4 || (col + row) >= 10)
                            {
                                Console.Write('.');
                            }
                            else
                            {
                                Console.Write(sec[index++]);
                                if (index == sec.Count)
                                {
                                    index = 0;
                                }
                            }
                        }

                        Console.WriteLine();
                    }
                    dnaLength--;
                }
            }
        }
     }
}