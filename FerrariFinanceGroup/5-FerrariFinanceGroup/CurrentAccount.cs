using System;
using System.Runtime.InteropServices;

namespace _5_FerrariFinanceGroup
{
    public class CurrentAccount
    {
        public Client owner;
        public int bankBranch;
        public int accountNumber;
        public double accountBalance = 0;
       public bool Withdraw(double ammount)
        {
            if (this.accountBalance < ammount)
            {
                return false;
            }

            this.accountBalance -= ammount;
            return true;

        }

        public void Deposit(double ammount)
        {
            this.accountBalance += ammount;
        }

        public bool Transfer(double ammount, CurrentAccount destinyAccount)
        {
            if (this.accountBalance < ammount)
            {
                return false;
            }

            this.accountBalance -= ammount;
            destinyAccount.Deposit(ammount);

            return true;

            
        }
    }
}