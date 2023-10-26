using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_LongTermInvestmentCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing Project 12 - Long Term Investment Calculator");

            double amountInvested = 1000;
            double yieldFactor = 1.0036; 

            for (int yearCounter = 1; yearCounter <=5;  yearCounter++)
            {
                for (int mounthCounter = 1;  mounthCounter <=12; mounthCounter++)
                {
                    amountInvested *= yieldFactor;
                }
                yieldFactor += 0.001;
            }

            Console.WriteLine("By the end of the investment, you'll have " + amountInvested);
            Console.WriteLine("Press enter to close program...");
            Console.ReadLine();
        }
    }
}
