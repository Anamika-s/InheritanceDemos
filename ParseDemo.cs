using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Demos
{
    class ParseDemo
    {
        static void Main()
        {
            byte x;
            Console.WriteLine("Enter x");
           // x = Byte.Parse(Console.ReadLine());
          //  Console.WriteLine(x);

            Byte.TryParse(Console.ReadLine(), out x);
            Console.WriteLine(x);



        }
    }
}
