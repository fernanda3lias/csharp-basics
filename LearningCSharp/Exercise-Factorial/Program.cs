using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(String[] args)
    {
        int factorial = 1;
        for (int i = 1; i < 11; i++)
        {
            factorial *= i;
            Console.WriteLine("Factorial of " + i + " = " + factorial);
        }
    }
}