using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Student //Base class
    {
        public string firstName;
        public string lastName;
       // public string place;
        public virtual void DisplayData()
        {
            Console.WriteLine("Full Name {0}", firstName + " " + lastName);
        }
    }

    class RegularStudent : Student
    {
        public override void DisplayData()
        {
            Console.WriteLine("Full Name {0}", firstName + " " + lastName + "-Regular");
        }
    }

    class LateralStudent : Student
    {
        public override void DisplayData()
        {
            Console.WriteLine("Full Name {0}", firstName + " " + lastName + "-Lateral");
        }
    }
    class SupplieStudent : Student
    {
        public override void DisplayData()
        {
            Console.WriteLine("Full Name {0}", firstName + " " + lastName + "-Supplie");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] stu = new Student[4];
            stu[0] = new Student();
            stu[1] = new RegularStudent
            {
                firstName = "Latha",
                lastName = "Manne"
                
            };
            stu[2] = new LateralStudent
            {
                firstName = "Hari",
                lastName = "Manne"
            };
            stu[3] = new SupplieStudent
            {
                firstName = "Srinivas",
                lastName = "Manne"
            };

            foreach (Student s in stu)
            {
                s.DisplayData();
            }

        }
    }
}
