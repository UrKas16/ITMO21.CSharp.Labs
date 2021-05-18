
class BankAccount
{
    //public void Populate(decimal balance)
    //{
    //    accNo = NextNumber();
    //    accBal = balance;
    //    accType = AccountType.Checking;
    //}
    public BankAccount()
    {
        accNo = NextNumber();
        accType = AccountType.Checking;
        accBal = 0;
    }

    public BankAccount(AccountType aType)
    {
        accNo = NextNumber();
        accType = aType;
        accBal = 0;
    }

    public BankAccount(decimal aBal)
    {
        accNo = NextNumber();
        accType = AccountType.Checking;
        accBal = aBal;
    }

    public BankAccount(AccountType aType, decimal aBal)
    {
        accNo = NextNumber();
        accType = aType;
        accBal = aBal;
    }



    public long Number()
    {
        return accNo;
    }

    public decimal Balance()
    {
        return accBal;
    }

    
    public string Type()
    {
        return accType.ToString();
    }

    private static long NextNumber()
    {
        return nextAccNo++;
    }

    public decimal Deposit(decimal amount)
    {
        accBal += amount;
        return accBal; 
    }

    public bool WithDraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount & amount >= 0;
        if (sufficientFunds)
        {
            accBal -= amount;                    
        }

        return sufficientFunds;
    }

    public void TransferFrom(BankAccount accForm, decimal amount)
    {
        if (accForm.WithDraw(amount))
        {
            this.Deposit(amount);
        }
        
    }



    private long accNo;
    private decimal accBal;
    private AccountType accType;

    private static long nextAccNo = 123;
}
