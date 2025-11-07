using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите сумму вклада: ");
        decimal money = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Введите количество месяцев: ");
        int months = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= months; i++)
        {
            money = money + money * 0.07m; 
        }

        Console.WriteLine("После " + months + " месяцев сумма будет: " + money);
    }
}