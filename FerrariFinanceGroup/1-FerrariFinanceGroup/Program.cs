using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_FerrariFinanceGroup
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

        }
    }
}
