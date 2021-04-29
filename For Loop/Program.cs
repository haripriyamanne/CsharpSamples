using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { { 1, 23, 3 }, 
                { 4, 52, 6 }, 
                { 71, 8, 98 } };//declaration and initialization
                                                           
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                    Console.Write("\n");//new line at each row  
            }
        }
    }
}
