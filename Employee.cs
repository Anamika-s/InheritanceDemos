using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Demos
{
    class Employee
    {
        int id;
        string name;
        string address;
        public Employee() { }
        public Employee(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void GetDetails()
        {
            Console.WriteLine("ENter ID");
            id = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("ENter Name");
            name = Console.ReadLine();
            Console.WriteLine("ENter Address");
            address = Console.ReadLine();


        }
        public void DisplayDetails()
        {
            Console.WriteLine("Employee ID " + id);
            Console.WriteLine("Name " + name);
            Console.WriteLine("Address is " + address);
        }

    }

    class FullTimeEmployee : Employee
    {
        string manager;
        string department;
        public FullTimeEmployee() : base() { }
        public FullTimeEmployee(int id, string name, string address, string manager, string department)
            : base(id, name, address)
        {
            this.manager = manager;
            this.department = department;
        }
        public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter Manager Name");
            manager = Console.ReadLine();
            Console.WriteLine("Enter Department Name");
            department = Console.ReadLine();



        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Department is " + department);
            Console.WriteLine("Manager Name is" + manager);
        }
    }


    class PartTimeEmployee : Employee
    {
        string duration;

        public PartTimeEmployee() : base()
        { }
        public PartTimeEmployee(int id, string name, string address, string duration)
        : base(id, name, address)
        {
            this.duration = duration;
        }


        public void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine("Enter Duration");
            duration = Console.ReadLine();




        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Duration is " + duration);


        }

    }
}