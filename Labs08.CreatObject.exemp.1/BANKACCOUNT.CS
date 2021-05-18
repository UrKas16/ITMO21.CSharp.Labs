using System;
using System.IO;
using System.Collections;

sealed class BankAccount : IDisposable
{
    //public void Populate(decimal balance)
    //{
    //    accNo = NextNumber();
    //    accBal = balance;
    //    accType = AccountType.Checking;
    //}
    public void Dispose()
    {
        if (!disposed)
        {
            StreamWriter swFile = File.AppendText("Transactions.Dat");
            swFile.WriteLine("Account number is {0}", accNo);
            swFile.WriteLine("Account balance is {0}", accBal);
            swFile.WriteLine("Account type is {0}", accType);
            swFile.WriteLine("Transactions:");
            foreach (BankTransaction tran in tranQueue)
            {
                swFile.WriteLine("Date/Time: {0}\tAmount:{1}", tran.When(), tran.Amount());
            }
            swFile.Close();
            disposed = true;
            GC.SuppressFinalize(this);
        }
    }



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
        BankTransaction tran = new BankTransaction(amount);
        tranQueue.Enqueue(tran);
        return accBal; 
    }

    public bool WithDraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount;
        if (sufficientFunds)
        {
            accBal -= amount;
            BankTransaction tran = new BankTransaction(-amount);
            tranQueue.Enqueue(tran);
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

    public Queue Transactions()
    {
        return tranQueue;
    }




    private long accNo;
    private decimal accBal;
    private AccountType accType;
    private static long nextAccNo = 123;
    private Queue tranQueue = new Queue();
    private bool disposed = false;
}
