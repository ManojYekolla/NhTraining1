using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day19Project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc =new XmlDocument();
            doc.Load("F:\\Nb\\XmlFiles\\Console1.xml");
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string text = node.InnerText; //or loop through its children as well
                Console.WriteLine(text);
            }
            Console.ReadLine();

        }
    }
}
