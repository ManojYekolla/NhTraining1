using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day19Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("F:\\Nb\\XmlFiles\\Console1.xml");

             XmlNode node = doc.DocumentElement.SelectSingleNode("/Employees/Employee");

            string text = node.InnerText;

            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
