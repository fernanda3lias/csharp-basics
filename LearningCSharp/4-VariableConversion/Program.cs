using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_VariableConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing Project 4 - Converting Variables");
            // AKA Type casting

            double salary = 1200.50;

            // int accepts 32 bits
            int intSalary = (int)salary;
            Console.WriteLine(intSalary);

            // long accepts 64 bits
            long universeAge = 13000000000;
            Console.WriteLine(universeAge);

            // short accepts 16 bits
            short productsQuantity = 150;
            Console.WriteLine(productsQuantity);

            // float needs to be kinda "confirmed" as a float :P
            float height = 1.80f;
            Console.WriteLine(height);

            // byte accepts 8 bits
            byte carQuantity= 255;
            Console.WriteLine(carQuantity);

            Console.WriteLine("Press enter to close program...");
            Console.ReadLine();
        }
    }
}
