using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] gender = { 'm', 'f', 'm', 'm', 'm', 'f', 'f', 'm', 'm', 'f' };
            int male = 0, female = 0;
            foreach (char g in gender)
            {
                if (g == 'm')
                    male++;
                else if (g == 'f')
                    female++;
            }
            Console.WriteLine("Number of male = {0}", male);
            Console.WriteLine("Number of female = {0}", female);
            Console.WriteLine("----------------------------");

            //Sorting the elements in a List using for each Loop
            List<int> numbersList = new List<int> { 4, 9, 6, 2, 1, 8, 3 };
            
           
            numbersList.Sort();
            Console.Write("Numbers after sorting ");
            foreach (int nl in numbersList)
            {
                Console.Write(nl+" ");
            }
           
            numbersList.Reverse();
            Console.WriteLine(" ");
            Console.Write("Numbers in Reverse order ");
            foreach (int nl in numbersList)
            {
                Console.Write(nl+" ");
            }

        }
    }
}
