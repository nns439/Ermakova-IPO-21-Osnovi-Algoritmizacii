using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите операцию:");
        Console.WriteLine("1 - Сложение");
        Console.WriteLine("2 - Вычитание");
        Console.WriteLine("3 - Умножение");

        int op = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите первое число: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double y = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        if (op == 1)
        {
            result = x + y;
            Console.WriteLine("Результат: " + result);
        }
        else if (op == 2)
        {
            result = x - y;
            Console.WriteLine("Результат: " + result);
        }
        else if (op == 3)
        {
            result = x * y;
            Console.WriteLine("Результат: " + result);
        }
        else
        {
            Console.WriteLine("Такой операции нет");
        }
    }
}