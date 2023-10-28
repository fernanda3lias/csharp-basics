using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_FerrariFinanceGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CurrentAccount joaoAccount = new CurrentAccount();

            joaoAccount.accountOwner = "João";
            joaoAccount.bankBranch = 863;
            joaoAccount.accountNumber = 863864;
            joaoAccount.accountBalance = 100;

            CurrentAccount joaoVitorAccount = new CurrentAccount();

            joaoVitorAccount.accountOwner = "João";
            joaoVitorAccount.bankBranch = 863;
            joaoVitorAccount.accountNumber = 863864;
            joaoVitorAccount.accountBalance = 100;

            Console.WriteLine(joaoAccount == joaoVitorAccount);
            Console.WriteLine(joaoAccount.accountNumber == joaoVitorAccount.accountNumber);

            Console.ReadLine();
        }
    }
}
