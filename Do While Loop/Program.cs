using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalAmount=0;
            string userChoice = "";
            string coffee;
            List<string> listOfItemsOrdered = new List<string>();
            do
            {
                Console.WriteLine("Enter the size of the coffee Small Medium Large");
              coffee = Console.ReadLine().ToLower();
                listOfItemsOrdered.Add(coffee);
                if (coffee == "small")
                {
                    totalAmount += 10;
                }
                else if (coffee == "medium")
                {
                    totalAmount += 20;
                }
                else if (coffee == "large")
                {
                    totalAmount += 30;
                }
                else
                {
                    Console.WriteLine("Please enter correct coffe size");
                }

                do
                {
                    Console.WriteLine("Do you want another Coffee YES or NO");
                  userChoice = Console.ReadLine().ToLower();
                    if (userChoice != "yes" && userChoice != "no")
                    {
                        Console.WriteLine("Please enter vaild choice");
                    }
                } while (userChoice != "yes" && userChoice != "no");

            } while (userChoice == "yes");

            Console.WriteLine("Ordered Total items are - {0}",listOfItemsOrdered.Count());
            foreach (string li in listOfItemsOrdered)
            {
                Console.WriteLine(li);
            }

            Console.WriteLine("Total Amount {0}", totalAmount);
        }

    }
}
