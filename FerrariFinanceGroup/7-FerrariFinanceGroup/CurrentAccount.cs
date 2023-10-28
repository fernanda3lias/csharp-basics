using System;
using System.Runtime.InteropServices;

namespace _7_FerrariFinanceGroup
{
    public class CurrentAccount
    {
        public Client Owner { get; set; }

        public static int TotalAccountsCreated{ get; private set;}
    
        private int _bankBranch;
        private int _accountNumber;
        private double _accountBalance = 0;

        public int BankBranch
        {
            get
            {
                return _bankBranch;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _bankBranch = value;
            }
        }
        public int AccountNumber
        {
            get
            {
                return _accountNumber;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }

                _accountNumber = value;
            }
        }
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

       public CurrentAccount(int bankBranch, int accountNumber)
        {
            BankBranch = bankBranch;
            AccountNumber = accountNumber;

            CurrentAccount.TotalAccountsCreated++;
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