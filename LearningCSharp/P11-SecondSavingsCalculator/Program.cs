using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_SecondSavingsCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing Project 11 - Savings Calculator");

            double amountInvested = 1000;

            for(int monthCounter = 1; monthCounter <= 12; monthCounter++)
            {
                amountInvested *= 1.0036;
                Console.WriteLine("After " + monthCounter +
                    " months you'll have " + amountInvested);
            }

            Console.WriteLine("Press enter to close program...");
            Console.ReadLine();
        }
    }
}
