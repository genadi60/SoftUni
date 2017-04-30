using System;
using System.Collections.Generic;

class LongestAlphabeticalWord
{
    static void Main()
    {
        string userInput = Console.ReadLine();
        int squareSide = int.Parse(Console.ReadLine());
        char[,] area = new char[squareSide, squareSide];
        int index = 0;
        string result = string.Empty;
        string result1 = string.Empty;
        string result2 = string.Empty;
        string resultMax = string.Empty;
        if (squareSide > 1)
        {
            List<string> sumRezult = new List<string>();
            for (int i = 0; i < squareSide; i++)
            {
                for (int j = 0; j < squareSide; j++)
                {
                    area[i, j] = userInput[index];
                    index++;
                    if (index == userInput.Length)
                    {
                        index = 0;
                    }
                }
            }
            for (int row = 0; row < squareSide; row++)
            {
                for (int col = 0; col < squareSide; col++)
                {
                    string longestRight = RightRead(row, col, area, squareSide);
                    string longestLeft = LeftRead(row, col, area);
                    result1 = LongestWord(longestRight, longestLeft);
                    string longestDown = DownRead(row, col, area, squareSide);
                    string longestUp = UpRead(row, col, area);
                    result2 = LongestWord(longestDown, longestUp);
                    result = LongestWord(result1, result2);
                    sumRezult.Add(result);
                }
            }
            for (int i = 0; i < sumRezult.Count; i++)
            {
                resultMax = LongestWord(sumRezult[i], resultMax);
            }
        }
        else
        {
            resultMax = userInput.Substring(0,1);
        }

        Console.WriteLine(resultMax);
    }

    static string LongestWord(string a, string b)
    {
        string longestWord = string.Empty;
        if (a.Length >= b.Length)
        {
            if (a.Length > b.Length)
            {
                longestWord = a;
            }
            else if (String.Compare(b, a) > 0)
            {
                longestWord = a;
            }
            else
            {
                longestWord = b;
            }
        }
        else
        {
            longestWord = b;
        }
        return longestWord;
    }

    static string UpRead(int row, int col, char[,] area)
    {
        string longest = string.Empty;
        string compare = area[row, col].ToString();
        for (int i = row; i >= 1; i--)
        {
            if(i >= 1 && area[i,col] < area[i - 1, col])
            {
                compare += area[i - 1, col];
                if(compare.Length >= longest.Length)
                {
                    if(compare.Length > longest.Length)
                    {
                        longest = compare;
                    }
                    else if(String.Compare(longest, compare) > 0)
                    {
                        longest = compare;
                    }
                }
            }
            else
            {
                compare = string.Empty; 
            }
        }
        return longest;
    }

    static string DownRead(int row, int col, char[,] area, int squareSide)
    {
        string longest = string.Empty;
        string compare = area[row, col].ToString();
        for (int i = row; i < squareSide - 1; i++)
        {
            if (i <= squareSide - 2 && area[i, col] < area[i + 1, col])
            {
                compare += area[i + 1, col];
                if (compare.Length >= longest.Length)
                {
                    if (compare.Length > longest.Length)
                    {
                        longest = compare;
                    }
                    else if (String.Compare(longest, compare) > 0)
                    {
                        longest = compare;
                    }
                }
            }
            else
            {
                compare = string.Empty;
            }
        }
        return longest;
    }

    static string LeftRead(int row, int col, char[,] area)
    {
        string longest = string.Empty;
        string compare = area[row, col].ToString();
        for (int i = col; i >= 1; i--)
        {
            if (i >= 1 && area[row, i] < area[row, i - 1])
            {
                compare += area[row, i - 1];
                if (compare.Length >= longest.Length)
                {
                    if (compare.Length > longest.Length)
                    {
                        longest = compare;
                    }
                    else if (String.Compare(longest, compare) > 0)
                    {
                        longest = compare;
                    }
                }
            }
            else
            {
                compare = string.Empty;
            }
        }
        return longest;
    }

    static string RightRead(int row, int col, char[,] area, int squareSide)
    {
        string longest = string.Empty;
        string compare = area[row, col].ToString();
        for (int i = col; i < squareSide - 1; i++)
        {
            if (i <= squareSide - 2 && area[row, i] < area[row, i + 1])
            {
                compare += area[row, i + 1];
                if (compare.Length >= longest.Length)
                {
                    if (compare.Length > longest.Length)
                    {
                        longest = compare;
                    }
                    else if (String.Compare(longest, compare) > 0)
                    {
                        longest = compare;
                    }
                }
            }
            else
            {
                compare = string.Empty;
            }
        }
        return longest;
    }
}