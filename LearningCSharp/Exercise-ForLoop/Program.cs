using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(String[] args)
    {
        for (int multiplier = 1; multiplier <= 10; multiplier++)
        {
            for (int counter = 0; counter <= 10; counter++)
            {
                Console.Write(multiplier + " * " + counter + " = " + multiplier * counter);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}
