using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Formatters
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            //string format date and time
            Console.WriteLine("Short date: {0:d}", today);
            Console.WriteLine("Long date: {0:D}", today);
            Console.WriteLine("Short time: {0:t}", today);
            Console.WriteLine("Long time: {0:T}", today);
            Console.WriteLine("Month: {0:M}", today);
            Console.WriteLine("Year: {0:Y}", today);
            Console.WriteLine("-----------------------------------");

            // various numeric notations.
            Console.WriteLine("Number: {0:N}", 127);
            Console.WriteLine("Scientific: {0:E}", 127);
            Console.WriteLine("Currency: {0:C}", 127);
            Console.WriteLine("Percent: {0:P}", 127);
            Console.WriteLine("Hexadecimal: {0:X}", 127);
            Console.WriteLine( "-----------------------------------");

            //String Formate index
            int oranges = 2;
            int apples = 4;
            int bananas = 3;

            string str1 = "There are {0} oranges, {1} apples and {2} bananas";
            string str2 = "There are {1} oranges, {2} bananas and {0} apples";

            Console.WriteLine(str1, oranges, apples, bananas);
            Console.WriteLine(str2, apples, oranges, bananas);
            Console.WriteLine("-----------------------------------");

            //string format Methods
            string msg = string.Format("There are {0} owls", 5);
            //var msg = string.Format("There are {0} owls", 5);
            Console.WriteLine(msg);

            Console.WriteLine("There are {0} eagles", 3);

            var builder = new StringBuilder();
            builder.AppendFormat("There are {0} hawks", 4);
            Console.WriteLine(builder);
        }
    }
}
