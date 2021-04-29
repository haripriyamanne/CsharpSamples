using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Student
    {
        public string firstName;
        public string lastName;
        public string place;

        public void DisplayData()
        {
            Console.WriteLine("Full Name {0}", firstName + " " + lastName);
        }
    }

    class RegularStudent : Student
    {
        public int regularRollNo;
        public void RegulaRno()
        {
            Console.WriteLine("Rollno is {0}", regularRollNo);
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
            rs.DisplayData();
            rs.RegulaRno();

            LateralStudent ls = new LateralStudent();
            ls.firstName = "Latha";
            ls.lastName = "Manne";
            ls.lateralRollNo = 130;
            ls.DisplayData();
            ls.LateralRno();
        }
    }
}
