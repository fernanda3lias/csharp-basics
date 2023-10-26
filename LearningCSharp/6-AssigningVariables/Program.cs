using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_AssigningVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing Project 6 - Assigning Variables");

            int age = 18;
            int ageJack = age;

            age = 20;

            Console.WriteLine(age);
            Console.WriteLine(ageJack);

            Console.WriteLine("Press enter to close program...");
            Console.ReadLine();
        }
    }
}
