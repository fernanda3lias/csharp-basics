using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Programa
{
    static void Main(String[] args)
    {
        for (int linha = 0; linha < 10; linha++)
        {
            //for (int coluna = 0; coluna < 10; coluna++)
            for (int coluna = 0; coluna <= linha; coluna++)
            {
                if (coluna > linha)
                {
                    break;
                }
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}