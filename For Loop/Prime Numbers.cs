using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Loop
{
    class Prime_Numbers
    {
        public void CheckingPrimeNumbers()
        {
            int  i, m = 0, flag = 0;
            Console.WriteLine("Enter the Number to check Prime Number");
            int number = int.Parse(Console.ReadLine());
            m = number / 2;
            for (i = 2; i <= m; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("{0} is not a Prime Number",number);
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.WriteLine("{0} is a Prime Number", number);
        }
    }
}


