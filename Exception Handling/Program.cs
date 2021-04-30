using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter any 2 Numbers");
            try
            {
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a / b;
                Console.WriteLine("C Value = " + c);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("2nd number should not be zero");
            }
            catch (FormatException)
            {
                Console.WriteLine("Enter only integer number");
            }
            finally
            {
                Console.WriteLine("Hello this is finally block");
            }
        }
    }
}
