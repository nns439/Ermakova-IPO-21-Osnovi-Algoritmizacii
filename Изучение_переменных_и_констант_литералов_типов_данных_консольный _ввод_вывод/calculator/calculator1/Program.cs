using System;

class Program
{ 
    static void Main()
    {
        Console.WriteLine("Введитепервое число:");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("Введитевторое число:");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("Сложение: " + (a + b));
        Console.WriteLine("Вычитание: " + (a - b));
        Console.WriteLine("Умножение: " + (a * b));

        if (b != 0)
        {
            Console.WriteLine("Деление: " + (a / b));
            Console.WriteLine("Остатокот деления: " + (a % b));
        }
        else
        {
        Console.WriteLine("Нельзяделить на ноль!");
        }

        a = a + 1;
        b = b + 1;
        Console.WriteLine("Инкремент: " + a + " и " + b);

        a = a - 1;
        b = b - 1;
        Console.WriteLine("Декремент: " + a + " и " + b);
        Console.WriteLine("Число 'a' > Числа 'b' и Число'b' > 0?" + ((a > b) && (b > 0)));
        Console.WriteLine("Число 'a' > Числа 'b' или Число 'b' > Числа 'a'?" + ((a > b) || (b > a)));

    }

 }
