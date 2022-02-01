using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Project2_Vowels_checking_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ch;
            Console.WriteLine("\n Enter any Single Character, To Check Wether it is an Vowels or Not : ");
            ch = Console.ReadLine();

            switch (ch)
            {
                case "a":
                    Console.WriteLine("Yes, Its an Vowel");
                    break;

                case "e":
                    Console.WriteLine("Yes, Its an Vowel");
                    break;

                case "i":
                    Console.WriteLine("Yes, Its an Vowel");
                    break;

                case "o":
                    Console.WriteLine("Yes, Its an Vowel");
                    break;

                case "u":
                    Console.WriteLine("Yes, Its an Vowel");
                    break;

                default:
                    Console.WriteLine("No, Its a Consonent");
                    break;
            }
            Console.ReadLine();
        }
    }
}
