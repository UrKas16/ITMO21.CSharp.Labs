using System;

namespace Greetengs
{
    class Greeter
    {
        static void Main(string[] args)
        {
            string myName;
            Console.WriteLine("Пожалуйста, введите ваше имя:");
            myName = Console.ReadLine();
            Console.WriteLine("Привет, {0}!", myName);
        }
    }
}
