using System;

class BiggestTriple
{
    static void Main()
    {
        string[] user = Console.ReadLine().Split(' ');
        int position = 0;
        int index = 0;
        int maxSum = 0;
        for (int i = 0; i < user.Length; i++)
        {
            int sum = 0;
            sum += int.Parse(user[i]);
            position = i;
            if (i + 1 < user.Length)
            {
                i++;
                sum += int.Parse(user[i]);
            }
            if (i + 1 < user.Length)
            {
                i++;
                sum += int.Parse(user[i]);
            }
            if (i <= 2)
            {
                maxSum = sum;
                index = position;
            }
            else if(maxSum < sum)
            {
                maxSum = sum;
                index = position;
            }
        }
        if(index + 3 > user.Length)
        {
            if(index + 2 <= user.Length)
            {
                Console.WriteLine("{0} {1}", user[index], user[index + 1]);
            }
            else
            {
                Console.WriteLine("{0}", user[index]);
            }
        }
        else
        {
            Console.WriteLine("{0} {1} {2}", user[index], user[index + 1], user[index + 2]);
        }
    }
}