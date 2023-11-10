using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    public class MathOperations
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Miltiply(int a, int b)
        {
            return a * b;
        }
        public static int Divide(int a, int b)
        {

            if (b == 0)
            {
                throw new DivideByZeroException("На ноль делить нельзя пока.");          
            }
            return a / b;
        }
    }
}


class Program
{

    static void Main(string[]args)
    {
        Console.WriteLine("Выберете операцию");
        Console.WriteLine("1. Сложение");
        Console.WriteLine("2. Вычитание");
        Console.WriteLine("3. Умножение");
        Console.WriteLine("4. Деление");

        Console.WriteLine("Введите номер операции");
        int operation = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите Первое число");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите Второе число");
        int b = int.Parse(Console.ReadLine());

        int result = 0;
        switch (operation)
        {
            case 1:
                result = MathOperations.Add(a, b);
                break;

            case 2:
                result = MathOperations.Subtract(a, b);
                break;
            case 3:
                result = MathOperations.Miltiply(a, b);
                break;
            case 4:
                result = MathOperations.Divide(a, b);
                break;

        }

        Console.WriteLine("Результат:" + result);
       
    }
}