using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingDoubleVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing Project 3 - Creating Double Variables");

            double height = 1.60;

            height /= 2;

            Console.WriteLine("Your height value is " + height);

            Console.WriteLine("Press enter to close program...");
            Console.ReadLine();
        }
    }
}
