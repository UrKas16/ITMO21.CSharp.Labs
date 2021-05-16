using System;

namespace BankAccount
{
    class Enum
    {
        public enum AccountType { Checking, Deposit }
        static void Main()
        {
            AccountType goldAccount;
            AccountType platinumAccount;
            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;
            Console.WriteLine("Тип учетной записи клиента: {0}", goldAccount);
            Console.WriteLine("Тип учетной записи клиента: {0}", platinumAccount);
        }
    }
}
