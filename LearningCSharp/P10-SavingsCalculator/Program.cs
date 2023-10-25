using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace P10_SavingsCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing Project 10 - Savings Calculator");

            double amountInvested = 1000.0;

            // 0.36% = 0.0036
            //amountInvested = amountInvested + amountInvested * 0.0036;
            //Console.WriteLine("After a month you'll have R$" + amountInvested);
            //amountInvested = amountInvested + amountInvested * 0.0036;
            //Console.WriteLine("After two months you'll have R$" + amountInvested);

            int monthCounter = 0;
            
            while (monthCounter < 12)
            {
                amountInvested = amountInvested + amountInvested * 0.0036;
                monthCounter++;

                Console.Write("After " + monthCounter + " months you'll have ");
                Console.WriteLine(amountInvested);
            }

            //Console.WriteLine(monthCounter);
            //Console.WriteLine(amountInvested);

            Console.WriteLine("Press enter to close program...");
            Console.ReadLine();
        }
    }
}
