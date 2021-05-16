
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

        created.Populate(balance);

        return created;
    }
    
    static void Write(BankAccount toWrite)
    {
        Console.WriteLine("Account number is {0}",  toWrite.Number());
        Console.WriteLine("Account balance is {0}", toWrite.Balance());
        Console.WriteLine("Account type is {0}", toWrite.Type());
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
