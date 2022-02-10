using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class AvgSpeed
    {
        
        private int time;
        private int distance;

        public int Time
        {
            set
            {
                time = value;
            }
        }
        public int Distance
        {
            set
            {
                distance = value;
            }
        }
        public int Speed
        {
            get
            {
                
                return distance/time;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            AvgSpeed obj = new AvgSpeed();
            obj.Distance = 840;
            obj.Time = 20;
            Console.WriteLine("Display the Auto-Implement  AvgSpeed is :{0}",obj.Speed);
            Console.ReadLine();


        }
    }
}

