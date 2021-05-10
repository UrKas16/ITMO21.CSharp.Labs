using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs04.CreatMetods
{
    class Test
    {
        public static void Main()
        {
            int f;
            bool ok;
            int x;
            int y;
            int greater;
            
            Console.WriteLine("Ввведите первое число: ");
            x = int.Parse(Console.ReadLine());

            ok = Utils.Factorial(x, out f);

            if (ok)
            {
                Console.WriteLine("Факториал числа {0} равен: {1}", x, f);
            }
            else
            {
                Console.WriteLine("Не возможно посчитать факториал числа " + x);
            
            }

            //Console.WriteLine("Ввведите второе число: ");
            //y = int.Parse(Console.ReadLine());

            //Console.WriteLine("Первое число = " + x);
            //Console.WriteLine("Первое число = " + y);

            //Utils.Swap(ref x, ref y);

            //Console.WriteLine("Теперь первое число = " + x);
            //Console.WriteLine("Теперь втрое число = " + y);

            //greater = Utils.Greater(x, y);

            //Console.WriteLine("Больше значение из двух чисел " + greater);

            Console.ReadLine();
        }
    }
}
