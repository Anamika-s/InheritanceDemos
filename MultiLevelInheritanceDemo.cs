using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritanceDemo
{
    class Student
    {
        int rn;
        string name;
        public void GetDetails()
        {
            Console.WriteLine("Enter RollNo" );
            rn = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            Console.WriteLine("RollNo is "  + rn);
            Console.WriteLine("Name is " + name);
        }
    }

    class Sports : Student
    {
        string sportsName;
        protected int score;
        public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter Sports Aame");
            sportsName= Console.ReadLine();
            Console.WriteLine("Enter Score in Sports");
            score = Byte.Parse(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Sports Name " + sportsName);
            Console.WriteLine("Score " + score);
        }

    }
    class Test : Sports
    {
        int[] marks = new int[] { 190, 89, 78, 67, 65 };
        protected int total = 0;
        public void CalculateMarks()
        {
            foreach (int temp in marks)
                total += temp;
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Total Marks " + total);
        }
    }

        class Result : Test
        {
            int total_marks = 0;
            public void CalcualteFinalResult()
            {
                total_marks = total + score;

            }
            public void DisplayDetails()
            {
                base.DisplayDetails();
                Console.WriteLine("Final Result is " + total_marks);
            }
        }
    class MultiLevelInheritanceDemo
    {
        static void Main()
        {
            Result res = new Result();
            res.GetDetails();
            res.CalculateMarks();
            res.CalcualteFinalResult();
            res.DisplayDetails();
        }
    }
}
