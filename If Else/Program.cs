using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Alphabet");
            string alphabet = Console.ReadLine();
            string convertToLower = alphabet.ToLower();
            if (convertToLower == "a" || convertToLower == "e" || convertToLower == "i" || convertToLower == "o" || convertToLower == "u")
            {
                Console.WriteLine("It is a vowel");
            }
            else
            {
                Console.WriteLine("It is not a Vowel");
            }
        }
    }
}
