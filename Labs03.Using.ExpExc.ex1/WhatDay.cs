// Упражнение 3. Учет високосных годов

using System;

namespace Labs03.Using.ExpExc.ex1
{
    class WhatDay
    {
        enum MonthName // Перечисление месяцев
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
        static void Main()
        {
            try
            {
                Console.WriteLine("Введите год: ");
                string line = Console.ReadLine(); // ввод номера дня года
                int yearNum = int.Parse(line);

                Console.WriteLine("Введите номер дня от 1 до 365: ");
                line = Console.ReadLine(); // ввод номера дня года
                int dayNum = int.Parse(line); // приведение к целочисленому значению

                bool isLeapYear = (yearNum % 4 == 0) && (yearNum % 100 != 0) || (yearNum % 400 == 0);

                //if (isLeapYear == true)
                //{
                //    Console.WriteLine("Год является високосным.");
                //}
                //else
                //{
                //    Console.WriteLine("Год не является високосным.");
                //}


                if (dayNum < 1 || dayNum > 365)
                {
                    throw new ArgumentOutOfRangeException("Число не соответствует номеру дня");
                }

                int monthNum = 0;

                foreach (int daysInMonth in DaysInMonths)
                {
                    if (dayNum <= daysInMonth)
                    {
                        break;
                    }
                    else
                    {
                        dayNum -= daysInMonth;
                        monthNum++;
                    }
                }

                MonthName temp = (MonthName)monthNum;
                string monthName = temp.ToString();

                Console.WriteLine("{0}, {1}", dayNum, monthName);
                Console.ReadLine();
            }

            catch (Exception caught)
            {
                Console.WriteLine(caught);

            }
        }
        static System.Collections.ICollection DaysInMonths
            = new int[12] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

    }
}

