using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_FerrariFinanceGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CurrentAccount account = new CurrentAccount(666, 696969);

            account.BankBranch = -99;
            account.AccountNumber = -99;

            Console.WriteLine(account.BankBranch);
            Console.WriteLine(account.AccountNumber);
            Console.WriteLine(CurrentAccount.TotalAccountsCreated);

            Console.ReadLine();

        }
    }
}
