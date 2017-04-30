using System;

class HalfSumElement
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int max = int.Parse(Console.ReadLine());
        int sum = max;
        for (int i = 0; i < n - 1; i++)
        {
            int userInput = int.Parse(Console.ReadLine());
            if(max < userInput)
            {
                max = userInput;
            }
            sum += userInput;
        }
        if(max == (sum - max))
        {
            Console.WriteLine(@"Yes
Sum = " + max);
        }
        else
        {
            Console.WriteLine(@"No
Diff = " + Math.Abs(2 * max - sum));
        }
    }
}