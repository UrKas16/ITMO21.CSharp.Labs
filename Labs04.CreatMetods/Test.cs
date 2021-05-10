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
            int x;
            int y;
            int greater;

            Console.WriteLine("Ввведите первое число: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Ввведите второе число: ");
            y = int.Parse(Console.ReadLine());

            greater = Utils.Greater(x, y);

            Console.WriteLine("Больше значение из двух чисел " + greater);
        }
    }
}
