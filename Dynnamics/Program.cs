using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynnamics
{
    public class Student
    {
        public void DisplayStudentInfo(int id)
        {
            Console.WriteLine("Id is Executed");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            dynamic stud = new Student(); //If you assign a class object to the dynamic type, then the compiler would not
                                          //check for correct methods and properties name of a dynamic type that holds the custom class object

            stud.DisplayStudentInfo(1);
            stud.DisplayStudentInfo(1,"Hari");// run - time error, no compile-time error
            //stud.DisplayStudentInfo("1");// run-time error, no compile-time error
            // stud.FakeMethod();// run-time error, no compile-time error
        }
    }

    
}

