using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_FerrariFinanceGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CurrentAccount joaoAccount = new CurrentAccount();

            joaoAccount.accountOwner = "João";

            joaoAccount.Deposit(500);
            Console.WriteLine("João's balance: " + joaoAccount.accountBalance);

            bool withdrawResult = joaoAccount.Withdraw(250);

            Console.WriteLine("Withdrawal result " + withdrawResult);
            Console.WriteLine("João's balance: " + joaoAccount.accountBalance);

            CurrentAccount amyAccount = new CurrentAccount();

            amyAccount.accountOwner = "Amy";

            joaoAccount.Transfer(200, amyAccount);

            Console.WriteLine("João's balance: " + joaoAccount.accountBalance);
            Console.WriteLine("Amy's balace: " + amyAccount.accountBalance);

            Console.ReadLine();
        }
    }
}
