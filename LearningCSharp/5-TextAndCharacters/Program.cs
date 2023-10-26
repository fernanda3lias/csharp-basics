using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_TextAndCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executing Project 5 - Text and Characters");

            // character ''
            char firstLetter = 'a';
            Console.WriteLine(firstLetter);

            firstLetter = (char)65;
            Console.WriteLine(firstLetter);

            firstLetter = (char)(firstLetter + 1);
            Console.WriteLine(firstLetter);


            // string ""
            string title = "Das ist mein titel";
            Console.WriteLine(title);

            string list = 
@"- first 
- second
- third";
            Console.WriteLine(list);

            list = "- first\n- second\n- third";
            Console.WriteLine(list);

            Console.WriteLine("Press enter to close program...");
            Console.ReadLine();
        }
    }
}
