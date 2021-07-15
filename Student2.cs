using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

    class Student2
    {
        int rn;
        string name;
        static string batchCode;
        int marks;
        public const string companyName="UST";
         static public void DisplayBatch()
         {
        batchCode = "B001";
        Console.WriteLine("Batch Code is " + batchCode);
         }
        public void GetDetails()
        {
       
            Console.WriteLine("Enter RollNo");
            rn = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            
            Console.WriteLine("Enter Marks");
            marks = Convert.ToByte(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            Console.WriteLine("RollNo is " + rn);
            Console.WriteLine("Name is " + name);
           
            Console.WriteLine("Marks are " + marks);
        }
    }


 