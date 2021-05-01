using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructor
{
    class DestructorDemo
    {
        public DestructorDemo()
        {
            Console.WriteLine("Constructor object created");
        }
        ~DestructorDemo()
        {
            Console.WriteLine("Object is destroyed");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DestructorDemo d1 = new DestructorDemo();
            //DestructorDemo d2 = new DestructorDemo();
            d1 = null;
            //d2 = null;
            // GC.Collect(); //if there are any unused objects associated with the program will be destroyed
                                   // in the middle of the program execution.
        }
    }
}
