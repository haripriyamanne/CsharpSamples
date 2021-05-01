using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Employee
    {
        int id, age;
        string address, name;
        public Employee() //Created a New Constructor
        {
            Console.WriteLine("ENTER EMPLOYEE DETAILS");
            Console.WriteLine("Enter the Employee Id");
            this.id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Employee Age");
            this.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Eemployee Name");
            this.name = Console.ReadLine();
            Console.WriteLine("Enter the Employee Address:");
            this.address = Console.ReadLine();
        }
        public Employee(Employee tempobj) //  Copy Constructor  which is temporary constructor
        {
            this.id = tempobj.id;
            this.age = tempobj.age;
            this.name = tempobj.name;
            this.address = tempobj.address;
        }
        public void Display()
        {
            Console.WriteLine();
            Console.WriteLine("Employee id is:  " + this.id);
            Console.WriteLine("Employee name is:  " + this.name);
            Console.WriteLine("Employee age is:  " + this.age);
            Console.WriteLine("Employee address is:  " + this.address);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee(e1);
            e1.Display();
            e2.Display();
        }
    }
}
