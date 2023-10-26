using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Scope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing Project 9 - Scope");

            int joaoAge = 19;
            int personQuantity = 1;
            bool accompanied = personQuantity >= 2;
            string message;

            // using "or": ||
            // using "and": &&

            if (accompanied == true) 
                message = "João is not alone.";
            
            // you can remove "{}" when executing a single line inside the conditional
            else
                message = "João is alone.";
            

            if (joaoAge >= 18 || accompanied == true)
            {
                Console.WriteLine("João can pass!");
                Console.WriteLine(message); 
            }
            else
                Console.WriteLine("João can't pass!");

           
            

            Console.WriteLine("Press enter to close program...");
            Console.ReadLine();
        }
    }
}
