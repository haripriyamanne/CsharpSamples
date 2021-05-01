using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int? n1 = null;
            int? n2 = 45;

            double? n3 = new double?();
            double? n4 = 3.14157;

            bool? boolval = new bool?();

            // display the values
            Console.WriteLine("Nullables at Show: {0}, {1}, {2}, {3}", n1, n2, n3, n4);
            Console.WriteLine("A Nullable boolean value: {0}", boolval);
            Console.ReadLine();
        }
    }
}
