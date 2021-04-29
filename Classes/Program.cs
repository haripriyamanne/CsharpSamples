using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Student
    {
        string firstName;
        string lastName;

        public Student()
            : this("No First Name", "No Last Name")
        {

        }

        public Student(string FirstName, string LastName)
        {
            firstName = FirstName;
            lastName = LastName;

        }

        public void Names()
        {
            Console.WriteLine("Full Name {0}", firstName + " " + lastName);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Names();
            Student s2 = new Student("Hari", "Manne");
            s2.Names();
        }
    }
}
}
