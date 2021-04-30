using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            // Floating Point
            float number = 43.27F;
            Console.WriteLine(number);

            int price = 51092;
            Console.WriteLine(price);

            double value = -11092.53D;
            Console.WriteLine(value);

            bool isValid = true;
            Console.WriteLine(isValid);

            sbyte level = 28;
            Console.WriteLine(level);

            short v = -1109;
            Console.WriteLine(v);
         
            long range = -7091821871L;
            Console.WriteLine(range);

            ushort values = 42019;
            Console.WriteLine(values);

            uint totalScore = 1151092;
            Console.WriteLine(totalScore);

            ulong ranges = 17091821871L;
            Console.WriteLine(ranges);

            char ch1 = '\u0042';
            char ch2 = 'x';
            Console.WriteLine(ch1);
            Console.WriteLine(ch2);

            decimal bankBalance = 53005.25M;
            Console.WriteLine(bankBalance);

            Console.WriteLine("Size of int: {0}", sizeof(int));
        }
    }
}
