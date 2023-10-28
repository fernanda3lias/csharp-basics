using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_FerrariFinanceGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Client joao =  new Client();

            //joao.name = "João";
            //joao.id = 331;
            //joao.occupation = "Developer";
            //account.owner = joao;
            //Console.WriteLine(joao.name);

            CurrentAccount account = new CurrentAccount();

            account.owner = new Client();
            account.owner.name = "João";
            account.owner.id = 331;
            account.owner.occupation = "Developer";

            account.accountBalance = 500;
            account.bankBranch = 666;
            account.accountNumber = 001;
            
            Console.WriteLine(account.owner.name);
            

            Console.ReadLine();
        }
    }
}
