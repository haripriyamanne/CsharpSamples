using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int biryaniCost = 0;
            int cokeCost = 0;
            int iceCost = 0;
            int totalBill = 0;

        Start:
            Console.WriteLine("select Menu 1- Biryani 2- Coke 3- Icecream");
            int userChoice = int.Parse(Console.ReadLine());
            switch (userChoice)
            {
                case 1:
                    Console.WriteLine("11-Single 12-Family Pack 13-Jumbo");

                    int userBiryaniChoice = int.Parse(Console.ReadLine());
                  
                    switch (userBiryaniChoice)
                    {
                        case 11:
                            biryaniCost += 200;
                            break;
                        case 12:
                            biryaniCost += 300;
                            break;
                        case 13:
                            biryaniCost += 400;
                            break;
                        default:
                            Console.WriteLine("Your Choice is Invaild");
                            break;
                    }

                    break;
                case 2:
                    Console.WriteLine("11-Diet Coke 12-Normal Coke");

                    int userCokeChoice = int.Parse(Console.ReadLine());
                    switch (userCokeChoice)
                    {
                        case 11:
                            cokeCost += 20;
                            break;
                        case 12:
                            cokeCost += 30;
                            break;
                        default:
                            Console.WriteLine("your choice Invaild");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("11-Vaniella 12-Strawberry 13-Chocolate");

                    int userIceChoice = int.Parse(Console.ReadLine());
                    switch (userIceChoice)
                    {
                        case 11:
                            iceCost += 20;
                            break;
                        case 12:
                            iceCost += 30;
                            break;
                        case 13:
                            iceCost += 40;
                            break;
                        default:
                            Console.WriteLine("your choice Invaild");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("your choice was invaild {0}", userChoice);
                    break;
            }

        Decide:
            Console.WriteLine("Do you want to Buy another order");
            string userDecision = Console.ReadLine();
            switch (userDecision.ToLower())
            {
                case "yes":
                    goto Start;

                case "no":
                    break;
                default:
                    Console.WriteLine("Your Choice is invaild {0}", userDecision);
                    goto Decide;
            }

            Console.WriteLine("Thank You for shooping with us");
            totalBill = biryaniCost + cokeCost + iceCost;
            Console.WriteLine("Total Bill Amout {0} ", totalBill);
        }
    }
}
