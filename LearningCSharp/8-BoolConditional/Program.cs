using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_BoolConditional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing Project 8 - Bool Conditional");

            int joaoAge = 19;
            int personQuantity = 1;

            bool accompanied = personQuantity >= 2;

            // using "or": ||
            // using "and": &&

            if (joaoAge >= 18 || accompanied == true)
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
