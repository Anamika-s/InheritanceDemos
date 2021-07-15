using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Demos
{
    class ProgramMain
    {
        static void Main()
        {
            Console.WriteLine("Employee");
            Employee employee = new Employee();
            employee.GetDetails();
            employee.DisplayDetails();


            Console.WriteLine("FullTimeEmployee");

            FullTimeEmployee full = new FullTimeEmployee();
            full.GetDetails();
           //full.GetFullTimeEmployeeDetails();
            full.DisplayDetails();
            //full.DisplayFullTimeEmployeeDetails();


            Console.WriteLine("PartTimeEmployee");


            PartTimeEmployee part = new PartTimeEmployee();
            part.GetDetails();
           // part.GetPartimeEmployeeDetails();
            part.DisplayDetails();
           //part.DisplayPartimeEmployeeDetails();
        }
    }
}
