using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Ternary
    {
        public void TernaryOperator()
        {
            int number = 10;
            // Ternary operator example
            bool isNumber10 = number == 10 ? true : false;
            Console.WriteLine("Number == 10 is {0}", isNumber10);
        }

    }
}
