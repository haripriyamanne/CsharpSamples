using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hiding
{
    class Student //Base class
    {
        public string firstName;
        public string lastName;
        public string place;

        //public Student(string Message)
        //{
        //    Console.WriteLine(Message);
        //}
        public void Display()
        {
            Console.WriteLine("Full Name is {0} Place is {1}", firstName + " " + lastName , place);
        }
    }
    class RegularStudent : Student
    {
        public int regularRollNo;

        public new void Display()
        {
           // base.Display();
            Console.WriteLine("Rollno is {0} Lateral", regularRollNo);
        }

    }
    class LateralStudent : Student
    {
        public int lateralRollNo;
        public void LateralRno()
        {
            Console.WriteLine("Rollno is {0}", lateralRollNo);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RegularStudent rs = new RegularStudent();
            rs.firstName = "Hari";
            rs.lastName = "Manne";
            rs.place = "Bhimavaram";
            rs.regularRollNo = 12;
            ((Student)rs).Display();
            // rs.RegularRno();

            LateralStudent ls = new LateralStudent();
            ls.firstName = "Latha";
            ls.lastName = "Manne";
            ls.place = "Mallavaram";
            ls.lateralRollNo = 130;
            ls.Display();
            ls.LateralRno();
        }
    }
}
