using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables Rules and Regulations
            //name	Valid
            //subject101	Valid
            //_age	Valid (Best practice for naming private member variables)
            //@break	Valid (Used if name is a reserved keyword)
            //101subject	Invalid (Starts with digit)
            //your_name	Valid
            //your name	Invalid (Contains whitespace)

            Console.WriteLine("Enter your Name");
            string name = Console.ReadLine();
            int age = 18;
            Console.WriteLine("Hello " + name); // + indicades concatenation
            Console.WriteLine("Hello {0} your age is {1}", name,age); //{0} indicades Placeholder

            // Displaying double quotes in c#
            string nameEmployee = "\"Hari\"";
            Console.WriteLine(nameEmployee);

            // Displaying new line character in c#
            string numbers = "One\nTwo\nThree";
            Console.WriteLine(numbers);

            // Displaying new line character in c#
            string location = "c:\\Programs\\DotNet\\Source\\CsharpSamples";
            Console.WriteLine(location);

            // C# verbatim literal
            string source = @"c:\Programs\DotNet\Source\CsharpSamples";
            Console.WriteLine(source);

        }
    }
}
