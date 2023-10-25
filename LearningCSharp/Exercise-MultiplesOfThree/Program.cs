using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_MultiplesOfThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise - Multiples of 3 between 1 and 100:");
            for(int number = 1; number <=100; number++)
            {
                if (number % 3 == 0)
                {
                    Console.WriteLine(number);
                }
            }
            Console.ReadLine();
        }
    }
}
