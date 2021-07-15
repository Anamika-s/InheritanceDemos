using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Demos
{
    class ProgramMain2
    {
        static void Main()
        {
            Employee employee = new Employee();
            Employee employee1 = new Employee(1, "ajay", "delhi");

            FullTimeEmployee fullTimeEmployee1 = new FullTimeEmployee();
            FullTimeEmployee fullTimeEmployee2 = new FullTimeEmployee(2, "deepak", "delhi", "lalit", "hr");


        }
    }
}
