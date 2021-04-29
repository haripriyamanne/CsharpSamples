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
