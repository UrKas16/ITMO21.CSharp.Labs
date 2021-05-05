// Лабораторная работа №2
// Упраженине №3 (



using System;

namespace StructType
{
    class Struct
    {
        public enum AccountType { Checking, Deposit }

        public struct BankAccount 
        {
            public long accNo;
            public decimal accBal;
            public AccountType accType;
        }
        static void Main()
        {
            BankAccount goldAccount;

            Console.WriteLine("Enter your account:");

            goldAccount.accType = AccountType.Checking;
            goldAccount.accBal = (decimal)3200.00;
            goldAccount.accNo = long.Parse(Console.ReadLine());

            //if (goldAccount.accNo == 321)
            //{
            //    Console.WriteLine("Account is true");
            //    Console.WriteLine("*** Account Summary ***");
            //    Console.WriteLine("Account Number {0}", goldAccount.accNo);
            //    Console.WriteLine("Account Type {0}", goldAccount.accType);
            //    Console.WriteLine("Account Balance {0}", goldAccount.accBal);
            //}

            //else
            //{
            //    Console.WriteLine("Wrong Account!!! Please try again!!");            

            //}


            Console.WriteLine("*** Account Summary ***");
            Console.WriteLine("Account Number {0}", goldAccount.accNo);
            Console.WriteLine("Account Type {0}", goldAccount.accType);
            Console.WriteLine("Account Balance {0}", goldAccount.accBal);
            Console.Read();
        }
    }
}
