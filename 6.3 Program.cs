using System;

/*3.Напишите перечисление Operation, которое содержит значения для арифметических операций:
Add, Subtract, Multiply и Divide.
Затем напишите метод, который принимает на вход два числа и значение этого перечисления
и возвращает результат выполнения соответствующей операции над числами.*/

namespace _6._3_КТ
{
    class Program
    {
         public enum Operation
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(10, 5, Operation.Add));       // 15
            Console.WriteLine(Calculate(10, 5, Operation.Subtract));  // 5
            Console.WriteLine(Calculate(10, 5, Operation.Multiply));  // 50
            Console.WriteLine(Calculate(10, 5, Operation.Divide));    // 2
        }

        public static double Calculate(double a, double b, Operation operation)
        {
            Func<double, double, double>[] operations =
            {
            (x, y) => x + y, // Add
            (x, y) => x - y, // Subtract
            (x, y) => x * y, // Multiply
            (x, y) =>
            {
                if (y == 0)
                    throw new DivideByZeroException();
                return x / y;
            } //Divide
        };
            return operations[(int)operation](a, b);
        }
    }
}