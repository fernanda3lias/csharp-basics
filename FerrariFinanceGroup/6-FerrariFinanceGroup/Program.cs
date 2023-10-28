using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_FerrariFinanceGroup
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CurrentAccount account = new CurrentAccount();
            Client client = new Client();

            client.Name = "João";
            client.ID = 13;
            client.Occupation = "Developer";

            account.AccountBalance = -10;
            account.Owner = client;

            Console.WriteLine(account.Owner.Name);
            Console.WriteLine(account.AccountBalance);

            Console.ReadLine();
        }
    }
}
