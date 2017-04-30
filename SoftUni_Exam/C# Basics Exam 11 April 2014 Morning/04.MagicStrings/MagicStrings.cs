using System;

class MagicStrings
{
    static void Main(string[] args)
    {
        int diff = int.Parse(Console.ReadLine());
        char[] letters = new char[] { 'k', 'n', 'p', 's' };
        int[] weight = new int[] { 1, 4, 5, 3 };
        char[] temp = new char[4];
        int sum = 0;
        int sum1 = 0;
        int count = 0;
        int stat = SumWeight(weight, sum, sum1, letters, temp, diff, count);
        if(stat == 0)
        {
            Console.WriteLine("No");
        }
    }

    static int SumControl(int[] weight, int sum, int sum1, char[] letters, char[] temp, int diff)
    {
        int index = 0;
        for (int i = 0; i < weight.Length; i++)
        {
            for (int j = 0; j < weight.Length; j++)
            {
                for (int k = 0; k < weight.Length; k++)
                {
                    for (int l = 0; l < weight.Length; l++)
                    {
                        sum1 = weight[i] + weight[j] + weight[k] + weight[l];
                        if(Math.Abs(sum - sum1) == diff)
                        {
                            Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", temp[0], temp[1], temp[2], temp[3], letters[i], letters[j], letters[k], letters[l]);
                            index = 1;
                        }
                    }
                }
            }
        }
        if (index == 1)
        {
            return index;
        }
        else
        {
            return -1;
        }
    }
 
   static int SumWeight(int[] weight, int sum, int sum1, char[] letters, char[] temp, int diff, int count)
    {
        for (int i = 0; i < weight.Length; i++)
        {
            for (int j = 0; j < weight.Length; j++)
            {
                for (int k = 0; k < weight.Length; k++)
                {
                    for (int l = 0; l < weight.Length; l++)
                    {
                        
                        sum = weight[i] + weight[j] + weight[k] + weight[l];
                        temp[0] = letters[i];
                        temp[1] = letters[j];
                        temp[2] = letters[k];
                        temp[3] = letters[l];
                        int index2 = SumControl(weight, sum, sum1, letters, temp, diff);
                        if(index2 == 1)
                        {
                            count++;
                        }

                    }
                }
            }
        }
        return count;
    }
}