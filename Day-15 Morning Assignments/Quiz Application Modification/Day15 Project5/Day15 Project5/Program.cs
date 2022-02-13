using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Project5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t\t\t ____::: Welcome To The Quiz Program By Manoj-Yekolla  :::____\t\t\t\n");
            //Variable Declaration Section
            int score = 0, ans;
            string name;
            Console.Write("  Enter The Name Of The Participant :  ");
            name = Console.ReadLine();
            Console.WriteLine("\n\n=====================================================================================================================");
            Console.WriteLine($"\n\t\tHi {name}, You are About To begin The Quiz on Cricket\n");
            Console.WriteLine("=====================================================================================================================\n");

            //Question No:1
            Console.WriteLine("\nQ1. In the 1996 World Cup final, only one bowler ended up picking multiple wickets. Who was it? ?");
            Console.WriteLine("\n1. Chaminda vaas  2. muttaiah muralitharan  3. jayasuriya  4. Arvinda de silva\n");
            Console.Write("\nEnter Your Answer :  ");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 4)
                score += 20;

            //Question No:2
            Console.WriteLine("\n\nQ2. Who remains the only captain to have not gotten a chance to bat in a World Cup final so far? ?");
            Console.WriteLine("\n1. steve waugh 2. ian chapell  3. wasim akram  4. Graham Gooch\n");
            Console.Write("\nEnter Your Answer :  ");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 1)
                score += 20;

            //Question No:3
            Console.WriteLine("\n\nQ3. Which edition holds the record for the most maidens in a World Cup final?");


            Console.WriteLine("\n1. 1975 2. 1979  3. 1983  4. 1987\n");
            Console.Write("\nEnter Your Answer :  ");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 3)
                score += 20;

            //Question No:4
            Console.WriteLine("\n\nQ4. Which bowler holds the unwanted record for the most expensive figures in a World Cup final? ?");
            Console.WriteLine("\n1. D Ferando 2. T Boult  3. N Kulesakhara  4. J Srinath\n");
            Console.Write("\nEnter Your Answer :  ");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 4)
                score += 20;

            //Question No:5
            Console.WriteLine("\n\nQ5. Who among these pair did not bowl their full quota of overs in the 2011 World Cup final? ?");
            Console.WriteLine("\n1. Munaf-Harbhjan 2. Sreesanth-Yuvaraj singh  3. Munaf-Sreesanth  4. Harbhajan-Yuvaraj\n");
            Console.Write("\nEnter Your Answer :  ");
            ans = Convert.ToInt32(Console.ReadLine());

            using (StreamWriter writer = new StreamWriter("F:\\Nb\\Mydata\\Quiz.txt", true))
            {
                writer.WriteLine("Name :{0},Score:{1}", name, score);
                writer.WriteLine("Thank you for attending quiz ,Admin let you know score");
                writer.Close();
                Console.WriteLine("File Append");
                Console.ReadLine();
            }



        }
    }
}
    

