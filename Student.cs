using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
    class Student
    {
        int rn;
        string name;
        string batchCode;
        int marks;
       
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
 
