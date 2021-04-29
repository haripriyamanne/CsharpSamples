using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize and assign values in different lines
            int[] evenNumbers = new int[3];
            evenNumbers[0] = 0;
            evenNumbers[1] = 2;
            evenNumbers[2] = 4;

            // Initialize and assign values in the same line
            int[] oddNumbers = { 1, 7, 5 };

            Console.WriteLine("Printing Even Numbers");

            // Retrieve and print even numbers from the array
            for (int i = 0; i < evenNumbers.Length; i++)
            {
                Console.WriteLine(evenNumbers[i]);
            }

            Console.WriteLine("Printing Odd Numbers");

            // Retrieve and print odd numbers from the array
            for (int i = 0; i < oddNumbers.Length; i++)
            {
                Console.WriteLine(oddNumbers[i]);
            }

            Array.Sort(oddNumbers);
            Console.WriteLine("Elements After Sorting");
            foreach (int i in oddNumbers)
            {
                Console.WriteLine(i);
            }
            Array.Reverse(oddNumbers);
            Console.WriteLine("Elements After Reverse");
            foreach (int i in oddNumbers)
            {
                Console.WriteLine(i);
            }


        }
    }
}
