using System;

namespace Labs03.Using.ExpExc.ex1
{
    class WhatDay
    {
        static void Main()
        {
            Console.WriteLine("Please enter a day number between 1 and 365: ");
            string line = Console.ReadLine();
            int dayNum = int.Parse(line);
            //Console.WriteLine(dayNum);

            int monthNom = 0;

            if (dayNum <= 31)
            { // January
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNom++;
            }

            if (dayNum <= 28)
            { // February
                goto End;
            }
            else
            {
                dayNum -= 28;
                monthNom++;
            }

            if (dayNum <= 28)
            { // March
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNom++;
            }

            if (dayNum <= 30)
            { // April
                goto End;
            }
            else
            {
                dayNum -= 30;
                monthNom++;
            }

            if (dayNum <= 31)
            { // May
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNom++;
            }

            if (dayNum <= 30)
            { // June
                goto End;
            }
            else
            {
                dayNum -= 30;
                monthNom++;
            }

            if (dayNum <= 31)
            { // Jule
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNom++;
            }

            if (dayNum <= 31)
            { // August
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNom++;
            }

            if (dayNum <= 30)
            { // September
                goto End;
            }
            else
            {
                dayNum -= 30;
                monthNom++;
            }

            if (dayNum <= 31)
            { // October
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNom++;
            }

            if (dayNum <= 30)
            { // November
                goto End;
            }
            else
            {
                dayNum -= 30;
                monthNom++;
            }

            if (dayNum <= 31)
            { // December
                goto End;
            }
            else
            {
                dayNum -= 31;
                monthNom++;
            }

            End:
                string monthName;

            switch (monthNom)
             {
                case 0:
                    monthName = "January";
                    break;
                case 1:
                    monthName = "February";
                    break;
                case 2:
                    monthName = "March";
                    break;
                case 3:
                    monthName = "April";
                    break;
                case 4:
                    monthName = "May";
                    break;
                case 5:
                    monthName = "June";
                    break;
                case 6:
                    monthName = "Jule";
                    break;
                case 7:
                    monthName = "August";
                    break;
                case 8:
                    monthName = "September";
                    break;
                case 9:
                    monthName = "October";
                    break;
                case 10:
                    monthName = "November";
                    break;
                case 11:
                    monthName = "December";
                    break;
                default:
                    monthName = "not done yet";
                    break;
            }

            Console.WriteLine("{0}, {1}", dayNum, monthName);
            Console.ReadLine();
        }
    }
}
