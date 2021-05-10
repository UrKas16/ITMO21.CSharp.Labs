using System;

namespace Labs03.Using.ExpExc.ex1
{
    class WhatDay
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a day number between 1 and 365: ");
            string line = Console.ReadLine();
            int dayNum = int.Parse(line);
            Console.WriteLine(dayNum);
        }
    }
}
