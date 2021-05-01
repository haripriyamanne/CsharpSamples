using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] marks = new int[] { 97, 92, 81, 60 ,36, 78, 89};

            // Define the query expression.
            IEnumerable<int> marksQuery =
                from mark in marks
                where mark > 80
                select mark;

            // Execute the query.
            foreach (int m in marksQuery)
            {
                Console.Write(m + " ");
            }
        }
    }
}
