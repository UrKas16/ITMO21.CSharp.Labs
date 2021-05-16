using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs07.Create_and_use_ref_var
{
    class Test
    {
        public static void Main()
        {
            //BankAccount b1 = new BankAccount();
            //b1.Populate(100);

            //BankAccount b2 = new BankAccount();
            //b2.Populate(100);

            //Console.WriteLine("До пересылки:");
            //Console.WriteLine("{0} {1} {2}", b1.Type(), b1.Number(), b1.Balance());
            //Console.WriteLine("{0} {1} {2}", b2.Type(), b2.Number(), b2.Balance());

            //b1.TransferFrom(b2, 10);

            //Console.WriteLine("После пересылки:");
            //Console.WriteLine("{0} {1} {2}", b1.Type(), b1.Number(), b1.Balance());
            //Console.WriteLine("{0} {1} {2}", b2.Type(), b2.Number(), b2.Balance());

            string message;
            Console.WriteLine("Введите ваше сообщение: ");
            message = Console.ReadLine();

            Labs04.CreatMetods.Utils.Reverse(ref message);

            Console.WriteLine(message);

        }
    }
}
