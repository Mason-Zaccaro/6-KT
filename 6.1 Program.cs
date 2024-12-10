using System;

/*1.Напишите перечисление DayOfWeek, которое содержит значения для дней недели:
Monday, Tuesday, Wednesday, Thursday, Friday, Saturday и Sunday.
Затем напишите метод, который принимает на вход значение этого перечисления
и выводит на консоль соответствующий день недели на русском языке.*/

namespace _6._1_КТ
{
    class Program
    {
        public enum DayOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            PrintRussianDay(DayOfWeek.Monday);
            PrintRussianDay(DayOfWeek.Friday);
            PrintRussianDay(DayOfWeek.Sunday);
        }

        public static void PrintRussianDay(DayOfWeek day)
        {
            string[] daysRussian =
            {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"
        };
            Console.WriteLine(daysRussian[(int)day]);
        }
    }
}