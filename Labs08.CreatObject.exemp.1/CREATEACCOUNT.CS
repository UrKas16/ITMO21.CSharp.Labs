
using System;
using System.IO;

class CreateAccount
{
    static void Main()
    {
        BankAccount berts = NewBankAccount();
        Write(berts);
        TestDeposit(berts);
        Write(berts);
        TestWithDraw(berts);
        Write(berts);


        BankAccount freds = NewBankAccount();
        Write(freds);
        TestDeposit(freds);
        Write(freds);
        TestWithDraw(freds);
        Write(freds);

        BankAccount acc1, acc2, acc3, acc4;

        acc1 = new BankAccount();
        acc2 = new BankAccount(AccountType.Deposit);
        acc3 = new BankAccount(100);
        acc4 = new BankAccount(AccountType.Deposit, 500);

        Write(acc1);
        Write(acc2);
        Write(acc3);
        Write(acc4);

    }

    static BankAccount NewBankAccount()
    {       
        BankAccount created = new BankAccount();

        //Console.Write("Enter the account number   : ");
        //long number = long.Parse(Console.ReadLine());        
                
        //long number = BankAccount.NextNumber();
                
        Console.Write("Enter the account balance! : ");
        decimal balance = decimal.Parse(Console.ReadLine());

        //created.accNo = number;
        //created.accBal = balance;
        //created.accType = AccountType.Checking;

        //created.Populate(balance);

        return created;
    }
    
    static void Write(BankAccount acc)
    {
        Console.WriteLine("Account number is {0}", acc.Number());
        Console.WriteLine("Account balance is {0}", acc.Balance());
        Console.WriteLine("Account type is {0}", acc.Type());
        Console.WriteLine("Transactions:");
        foreach (BankTransaction tran in acc.Transactions())
        {
            Console.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
        }
        Console.WriteLine();

    }

    public static void TestDeposit(BankAccount acc)
    {
        Console.WriteLine("¬ведите сумму пополнени€: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        while (amount < 0)
        {
            Console.WriteLine("Error!!! Try again!");
            amount = decimal.Parse(Console.ReadLine());

        }

         acc.Deposit(amount);
            
    }
    
    public static void TestWithDraw(BankAccount acc)
    {
        Console.WriteLine("¬ведите сумму списани€: ");
        decimal amount = decimal.Parse(Console.ReadLine());

        while ((!acc.WithDraw(amount)) | (amount <= 0))
        {
            Console.WriteLine("—умма превышает остаток на счете!!!");
            Console.WriteLine("¬ведите верную сумму! ¬аш остаток равен - {0}, руб.", acc.Balance());
            amount = decimal.Parse(Console.ReadLine());
            
        }

        
    }
}
