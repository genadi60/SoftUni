using System;
using System.Collections.Generic;
using System.Linq;

class CommandInterpreter
{
    
    static void Main()
    {
        List<string> inputCollection = Console.ReadLine()
            .Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries)
            .ToList();
        
        List<string> inputCode = Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        while (inputCode[0] != "end")
        {
            bool isOk = true;
            switch (inputCode[0])
            {
                case "reverse":
                    int start = int.Parse(inputCode[2]);
                    int count = int.Parse(inputCode[4]);
                    isOk = ReverseCode(inputCollection, start, count, isOk);
                    break;
                case "sort":
                    start = int.Parse(inputCode[2]);
                    count = int.Parse(inputCode[4]);
                    isOk = SortCode(inputCollection, start, count, isOk);
                    break;
                case "rollLeft":
                    count = int.Parse(inputCode[1]);
                    isOk = RollLeftCode(inputCollection, count, isOk);
                    break;
                case "rollRight":
                    count = int.Parse(inputCode[1]);
                    isOk = RollRightCode(inputCollection, count, isOk);
                    break;
                default:
                    isOk = false;
                    break;
            }
            if (!isOk)
            {
                Console.WriteLine("Invalid input parameters.");
            }

            inputCode.Clear();
            inputCode = Console.ReadLine()
            .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
            .ToList();
        }

        Console.WriteLine($"[{string.Join(", ", inputCollection)}]");
    }

    static bool ReverseCode(List<string> inputCollection, int start, int count, bool isOk)
    {
        if (start >= 0 &&
            start < inputCollection.Count &&
            count >= 0 &&
            (start + count) <= inputCollection.Count)
        {
            inputCollection.Reverse(start, count);
        }
        else
        {
            isOk = false;
        }
        return isOk;
    }

    static bool SortCode(List<string> inputCollection, int start, int count, bool isOk)
    {
        if (start >= 0 &&
            start < inputCollection.Count &&
            count >= 0 &&
            (start + count) <= inputCollection.Count)
        {
            inputCollection.Sort(start, count, null);
        }
        else
        {
            isOk = false;
        }
        return isOk;
    }
    
    static bool RollLeftCode(List<string> inputCollection, int count, bool isOk)
    {
        if (count >= 0)
        {
            string temp = string.Empty;
            for (int i = 0; i < count % inputCollection.Count; i++)
            {
                temp = inputCollection[0];
                for (int j = 0; j < inputCollection.Count - 1; j++)
                {
                    inputCollection[j] = inputCollection[j + 1];
                }
                inputCollection[inputCollection.Count - 1] = temp;
            }
        }
        else
        {
            isOk = false;
        }
        return isOk;
    }

    static bool RollRightCode(List<string> inputCollection, int count, bool isOk)
    {
        if (count >= 0)
        {
            string temp = string.Empty;
            for (int i = 0; i < count % inputCollection.Count; i++)
            {
                temp = inputCollection[inputCollection.Count - 1];
                for (int j = inputCollection.Count - 1; j > 0; j--)
                {
                    inputCollection[j] = inputCollection[j - 1];
                }
                inputCollection[0] = temp;
            }
        }
        else
        {
            isOk = false;
        }
        return isOk;
    }
}