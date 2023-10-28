using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_FerrariFinanceGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CurrentAccount joaoAccount = new CurrentAccount();

            joaoAccount.accountOwner = "João";

            Console.WriteLine(joaoAccount.accountBalance);

            Console.ReadLine();
        }
    }
}
