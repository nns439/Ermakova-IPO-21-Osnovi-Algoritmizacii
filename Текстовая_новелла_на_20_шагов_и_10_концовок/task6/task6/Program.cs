using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Выберите операцию:");
        Console.WriteLine("1 - Сложение");
        Console.WriteLine("2 - Вычитание");
        Console.WriteLine("3 - Умножение");

        int num = Convert.ToInt32(Console.ReadLine());

        if (num == 1)
            Console.WriteLine("Выбрано сложение");
        else if (num == 2)
            Console.WriteLine("Выбрано вычитание");
        else if (num == 3)
            Console.WriteLine("Выбрано умножение");
        else
            Console.WriteLine("Такой операции нет");
    }
}