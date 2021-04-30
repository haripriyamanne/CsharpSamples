using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Bank
    {
        private double balance;
        public double BalanceInAccount
        {
            get
            {
                return balance;
            }
            set
            {
                // validate the value
                if (value < 0)
                {
                    Console.WriteLine("Value cannot be negative");
                }
                balance = value;
            }
        }
    }
    class BankUser
    {
        public static void Main()
        {
            Bank SBI = new Bank();
            SBI.BalanceInAccount = 100;
            Console.WriteLine(SBI.BalanceInAccount);
            SBI.BalanceInAccount = -50;
            Console.WriteLine(SBI.BalanceInAccount);
        }
    }
}
