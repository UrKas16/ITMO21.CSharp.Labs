using System;

namespace Divider
{
    class DivideIt
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите, пожалуйста, первое число:");
                string temp = Console.ReadLine();
                int i = Int32.Parse(temp);

                Console.WriteLine("Введите, пожалуйста, второе число:");
                temp = Console.ReadLine();
                int j = Int32.Parse(temp);

                Console.WriteLine("Ваши числа: {0}, {1}", i, j);

                //decimal z = (decimal)i;
                //decimal w = (decimal)j;

                //decimal m = z / w;
                //Console.WriteLine("Результат деления чисел {0} / {1} = {2}", z, w, m);

                int m = i / j;
                Console.WriteLine("Результат деления чисел {0} / {1} = {2}", i, j, m);
            }
            catch(Exception e)
            {
                Console.WriteLine("An exception was thrown: {0}", e);
            }
            Console.Read();
        }
    }
}
