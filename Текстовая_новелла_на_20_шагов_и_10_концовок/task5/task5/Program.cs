using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите сумму вклада: ");
        double money = Convert.ToDouble(Console.ReadLine());

        double percent; 
        double bonus = 15; 

        if (money < 100)
            percent = 5;
        else if (money <= 200)
            percent = 7;
        else
            percent = 10;

        double total = money + money * percent / 100 + bonus;

        Console.WriteLine("Итоговая сумма: " + total);
    }
}
