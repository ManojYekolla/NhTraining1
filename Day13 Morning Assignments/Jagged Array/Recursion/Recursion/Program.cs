using System;

namespace Recursion

{

    class Program

    {

        static void Main(string[] args)

        {

            Console.WriteLine("Enter a number");

            int number = Convert.ToInt32(Console.ReadLine());

            long fact = GetFactorial(number);

            Console.WriteLine("{0} factorial is {1}", number, fact);

            Console.ReadLine();

        }



        private static long GetFactorial(int number)

        {

            if (number == 0)

            {

                return 1;

            }

            return number * GetFactorial(number - 1);

        }

    }

}