using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Range Number");
            int userRange = int.Parse(Console.ReadLine());

            //Print the Odd Numbers in a given range
            int startingValue =1;
            Console.WriteLine("Odd Numbers are: ");
            while (startingValue <= userRange)
            {
                if (startingValue % 2 != 0)
                    Console.WriteLine(startingValue);
                startingValue++;   //increasing loop counter by 1
            }

            //Print the Even Numbers in a given range
            startingValue = 1;
            Console.WriteLine("Even Numbers are: ");
            while (startingValue <= userRange)
            {
                if (startingValue % 2 == 0)
                    Console.Write(startingValue+" ");
                startingValue++;   //increasing loop counter by 1
            }

        }
    }
}

