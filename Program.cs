using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 class Program
{
    static void Main()
    {
        Day3Demos.Student.DisplayManagerName();

        Console.WriteLine("Studnet1");
        Day3Demos.Student student1 = new Day3Demos.Student();// Here Def const will be called
        student1.GetDetails();
        student1.DisplayDetails();


        Console.WriteLine("Studnet2, Here we are passing rn to the obejct");
        Day3Demos.Student student2 = new Day3Demos.Student(2);// Here Para const will be called
        //student2.GetDetails();
        student2.DisplayDetails();


        Console.WriteLine("Studnet2, Here we are passing rn & name to the obejct");
        Day3Demos.Student student3 = new Day3Demos.Student(3,"Ajay"); // Here Para const will be called
        student3.DisplayDetails();


        Console.WriteLine("Studnet2, Here we are every value to the obejct");
        Day3Demos.Student student4 = new Day3Demos.Student(4, "Ajay", "B001", 90);
        // Here Para const will be called;
        student4.DisplayDetails();



        Console.WriteLine("Studnet2, Here we are passing student4 object to new obejct");
        Day3Demos.Student student5 = new Day3Demos.Student(student4); // Here Copy Const will be calledr
        student5.DisplayDetails();


        //Student2 student1 = new Student2();
        //Student2.DisplayBatch();
        //Console.WriteLine("Employees of " +  Student2.companyName);
        //student1.GetDetails();
        //student1.DisplayDetails();

        //Student2 student2;  // declaration , memory is not allocated
        //student2 = new Student2();
        //student2.GetDetails();
        //student2.DisplayDetails();

        //Student2 student3 = new Student2();
        //student3.GetDetails();
        //student3.DisplayDetails();
        //Console.Read();
    }
}