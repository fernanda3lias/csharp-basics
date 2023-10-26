using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Conditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing Project 7 - Conditional");

            int joaoAge = 19;

            if (joaoAge >= 18)
            {
                Console.WriteLine("João can pass!");
            }
            else
            {
                Console.WriteLine("João can't pass!");
            }

            Console.WriteLine("Press enter to close program...");
            Console.ReadLine();
        }
    }
}
