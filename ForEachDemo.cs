using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Demos
{
    class ForEachDemo
    {
        static void Main()
        {
            int[] num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = 10;
                Console.WriteLine(num[i]);
            }

            foreach(int temp in num)
            {               
                Console.WriteLine(temp);
            }
        }

    }
}
