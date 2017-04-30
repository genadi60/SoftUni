using System;
using System.Collections.Generic;

class MagicCarNumbers
{
    static void Main()
    {
        int magNum = int.Parse(Console.ReadLine());
        int counter = 0;
        string templ = string.Empty;
        int[] num = new int[10];
        List<char> leters = new List<char> { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
        for (int i = 0; i < leters.Count; i++)
        {
            int ind = (leters[i] - 'A' + 1) * 10;
            num[i] = ind;

        }
        for (int X = 0; X < num.Length; X++)
        {
            for (int Y = 0; Y < num.Length; Y++)
            {
                for (int a = 0; a <= 9; a++)
                {
                    for (int b = 0; b <= 9; b++)
                    {
                        if (magNum == num[2] + num[0] + a + a + a + a + num[X] + num[Y])
                        {
                            string number = "CA" + a + a + a + a + leters[X] + leters[Y];
                            if (number != templ)
                            {
                                counter++;
                            }
                            templ = "CA" + a + a + a + a + leters[X] + leters[Y];
                        }
                        else if (a != b)
                        {
                            if (magNum == num[2] + num[0] + a + b + b + b + num[X] + num[Y])
                            {
                                counter++;
                            }
                            if (magNum == num[2] + num[0] + a + a + a + b + num[X] + num[Y])
                            {
                                counter++;
                            }
                            if (magNum == num[2] + num[0] + a + a + b + b + num[X] + num[Y])
                            {
                                counter++;
                            }
                            if (magNum == num[2] + num[0] + a + b + a + b + num[X] + num[Y])
                            {
                                counter++;
                            }
                            if (magNum == num[2] + num[0] + a + b + b + a + num[X] + num[Y])
                            {
                                counter++;
                            }
                        }
                    }
                }
            }
        }
        Console.WriteLine(counter);
    }
}
/*string bul = "1111";
        int result = Convert.ToInt32(bul, 2);
        Console.WriteLine(result);*/
