using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;

                Console.WriteLine("Enter the First Number :");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Second Number :");
                b = Convert.ToInt32(Console.ReadLine());

                c = a / b;

                Console.WriteLine("Answer :{0}", c);
                Console.ReadLine();

            }
            catch (OverflowException)
            {
                Console.WriteLine("---------Overflow Exception--------------");
                Console.WriteLine("Enter 0 to 8000000 and above does not valid :");

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("--------Divide By Zero Exception-------");
                Console.WriteLine("canot divide by zero ");

            }
            catch (FormatException)
            {
                Console.WriteLine("-----------FormatException---------");
                Console.WriteLine("only Numbers are allowed ");

            }
            catch (Exception) //super exception
            {
                Console.WriteLine("---------Super Exception----------");
                Console.WriteLine("some errors are occured : please contact manojy@gmail.com");

            }
            finally
            {
                Console.WriteLine("\n\n\nDesigned by Manoj Yekolla");
                Console.ReadLine();
            }
        }
    }
}

