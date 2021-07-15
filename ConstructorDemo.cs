using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Demos
{
    class Student
    {
        int rn;
        string name;
        string batchCode;
        int marks;
        static string manager;

        // Default Constructor
        public Student() { }    
        
        // Parameterized Constructor
        public Student(int x)
        {
            rn = x;
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Batch Code");
            batchCode = Console.ReadLine();
            Console.WriteLine("Enter Marks");
            marks = Convert.ToByte(Console.ReadLine());
        }

        // Parameterized Constructor
        public Student(int x, string y)
        {
            rn = x;
            name = y;
            Console.WriteLine("Enter Batch Code");
            batchCode = Console.ReadLine();
            Console.WriteLine("Enter Marks");
            marks = Convert.ToByte(Console.ReadLine());
        }

        // Fully Parameterized Constructor

        public Student(int x, string y, string z, int a)
        {
            rn = x;
            name = y; 
            batchCode = z;
            marks = a;
        }

        // Copy Constructor
        public Student(Student obj)
        {
            Console.WriteLine("Enter RollNo");
            rn = Convert.ToByte(Console.ReadLine());
            name = obj.name;
            marks = obj.marks;
            batchCode = obj.batchCode;
        }
         
        // Static Constructor

          static Student()
          {
            manager = "XYZ";
          }
        public static void DisplayManagerName()
        {
            Console.WriteLine("Manager is " + manager);
        }

        public void GetDetails()
        {
            Console.WriteLine("Enter RollNo");
            rn = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Batch Code");
            batchCode = Console.ReadLine();
            Console.WriteLine("Enter Marks");
            marks = Convert.ToByte(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            Console.WriteLine("RollNo is " + rn);
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Batch Code is " + batchCode);
            Console.WriteLine("Marks are " + marks);
        }

    }
}
