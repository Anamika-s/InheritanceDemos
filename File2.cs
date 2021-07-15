using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Demos
{
    class File2
    {
        static void Main()
        {
            // Array of Objects
            Student[] students = new Student[10];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter Details for {0}", i + 1);
                students[i] = new Student();
                students[i].GetDetails();
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Details for Studnet No {0}", i + 1);

                students[i].DisplayDetails();
            }
        }
    }
}
