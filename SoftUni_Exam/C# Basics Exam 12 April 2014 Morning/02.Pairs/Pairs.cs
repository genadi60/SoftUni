using System;

class Pairs
{
    static void Main()
    {
        string[] userInput = Console.ReadLine().Split(' ');
        int[] sumPairs = new int[userInput.Length/2];
        bool yesNo = true;
        for (int i = 0; i < userInput.Length - 1; i ++)
        {
            sumPairs[i/2] = (int.Parse(userInput[i]) + int.Parse(userInput[i + 1]));
            i++;
        }
        int maxDiff = 0;
        int max = 0;
        int min = 0;
        int comp = sumPairs[0];
        for (int i = 0; i < sumPairs.Length; i++)
        {
            if(comp != sumPairs[i])
            {
                max = Math.Max(sumPairs[i], sumPairs[i - 1]);
                min = Math.Min(sumPairs[i], sumPairs[i - 1]);
                maxDiff = Math.Max(maxDiff, max - min);
                yesNo = false;
            }  
        }
        if (yesNo)
        {
            Console.WriteLine("Yes, value={0}", comp);
        }
        else
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }
}