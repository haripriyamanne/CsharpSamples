using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        class CalculationFactorialOfANumber
        {
            public int Factorial(int number) // Method with Parameters
            {
                int result;    /* local variable declaration */
                if (number == 1)
                {
                    return 1;
                }
                else
                {
                    result = Factorial(number - 1) * number;
                    return result;
                }
            }
        }
        static void Main(string[] args)
        {
            CalculationFactorialOfANumber f = new CalculationFactorialOfANumber();
            Console.WriteLine("Factorial of 7 is : {0}", f.Factorial(7));//calling the Factorial Method 
            Console.WriteLine("Factorial of 8 is : {0}", f.Factorial(8));
            Console.ReadLine();
        }
    }
}

