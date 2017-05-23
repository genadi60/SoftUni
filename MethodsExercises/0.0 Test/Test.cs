using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._0_Test
{
    class Test
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            var counter = 0;
            for (int i = 0; i < n.Length / 2; i++)
            {
                if (n[i] == n[n.Length - 1 - i])
                {
                    counter++;
                }
            }
            if (counter == n.Length/2)
            {
                Console.WriteLine(n);
            }
        }
    }
}
