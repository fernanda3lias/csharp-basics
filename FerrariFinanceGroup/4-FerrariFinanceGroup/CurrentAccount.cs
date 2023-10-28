public class CurrentAccount
{
    public string accountOwner;
    public int bankBranch;
    public int accountNumber;
    public double accountBalance = 0;

    public bool Withdraw(double ammount)
    {
        if(this.accountBalance < ammount)
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
        if(this.accountBalance < ammount)
        {
            return false;
        } 
        
        this.accountBalance -= ammount;
        destinyAccount.Deposit(ammount);

        return true;
        
    }
}