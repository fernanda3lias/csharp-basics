using System;
using System.Runtime.InteropServices;

namespace _6_FerrariFinanceGroup
{
    public class CurrentAccount
    {
        public Client Owner { get; set; }
        public int BankBranch { get; set; }
        public int AccountNumber { get; set; }

        private double _accountBalance = 0;

        public double AccountBalance
        {
            get
            {
                return _accountBalance;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _accountBalance = value;
            }
        }
       public bool Withdraw(double ammount)
        {
            if (_accountBalance < ammount)
            {
                return false;
            }

            _accountBalance -= ammount;
            return true;

        }

        public void Deposit(double ammount)
        {
            _accountBalance += ammount;
        }

        public bool Transfer(double ammount, CurrentAccount destinyAccount)
        {
            if (_accountBalance < ammount)
            {
                return false;
            }

            _accountBalance -= ammount;
            destinyAccount.Deposit(ammount);

            return true;

            
        }
    }
}