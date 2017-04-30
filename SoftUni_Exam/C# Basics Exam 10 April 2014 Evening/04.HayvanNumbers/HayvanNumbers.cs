using System;

class HayvanNumbers
{
    static void Main()
    {
        int userSum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int[] a = new int[3];
        int[] b = new int[3];
        int[] c = new int[3];
        bool index = true;
        for (int i = 5; i <= 9; i++)
        {
            for (int j = 5; j <= 9; j++)
            {
                for (int k = 5; k <= 9; k++)
                {
                    a[0] = i;
                    a[1] = j;
                    a[2] = k;
                    int sum = a[0] + a[1] + a[2];
                    int abc = a[0]*100 + a[1]*10 + a[2];
                    for (int l = 5; l <= 9; l++)
                    {
                        for (int m = 5; m <= 9; m++)
                        {
                            for (int n = 5; n <= 9; n++)
                            {
                                b[0] = l;
                                b[1] = m;
                                b[2] = n;
                                int sum2 = b[0] + b[1] + b[2];
                                int def = b[0]*100 + b[1]*10 + b[2];
                                for (int p = 5; p <= 9; p++)
                                {
                                    for (int q = 5; q <= 9; q++)
                                    {
                                        for (int r = 5; r <= 9; r++)
                                        {
                                            c[0] = p;
                                            c[1] = q;
                                            c[2] = r;
                                            int sum3 = c[0] + c[1] + c[2];
                                            int ghi = c[0]*100 + c[1]*10 + c[2];
                                            if (userSum == sum + sum2 + sum3 && def - abc == diff && ghi - def == diff)
                                            {
                                                Console.WriteLine("{0}{1}{2}", abc, def, ghi);
                                                index = false;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (index)
        {
            Console.WriteLine("No");
        }
    }
}