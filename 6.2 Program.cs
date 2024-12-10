using System;

/*2.Напишите перечисление Color, которое содержит значения для цветов:
Red, Green, Blue, Yellow, Cyan и Magenta.
Затем напишите метод, который принимает на вход значение этого перечисления
и возвращает его шестнадцатеричный код в виде строки.*/

namespace _6._2_КТ
{
    class Program
    {
        public enum Color
        {
            Red,
            Green,
            Blue,
            Yellow,
            Cyan,
            Magenta
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetHexCode(Color.Red));
            Console.WriteLine(GetHexCode(Color.Green));
            Console.WriteLine(GetHexCode(Color.Blue));
            Console.WriteLine(GetHexCode(Color.Yellow));
            Console.WriteLine(GetHexCode(Color.Cyan));
            Console.WriteLine(GetHexCode(Color.Magenta));
        }

        public static string GetHexCode(Color color)
        {
            string[] hexCode =
            {
            "#FF0000", // Red
            "#00FF00", // Green
            "#0000FF", // Blue
            "#FFFF00", // Yellow
            "#00FFFF", // Cyan
            "#FF00FF"  // Magenta
        };
            return hexCode[(int)color];
        }
    }
}