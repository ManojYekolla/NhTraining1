using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Append_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.
            using (StreamWriter writer = new StreamWriter("F:\\Nb\\Mydata\\HelloManoj Y.txt", true))
            {
                writer.WriteLine("Hlo Gabbar");
                writer.WriteLine("Welecome To Punjab");
                writer.Close();
                Console.WriteLine("File Append");
                Console.ReadLine();
            }
        }
    }
}
