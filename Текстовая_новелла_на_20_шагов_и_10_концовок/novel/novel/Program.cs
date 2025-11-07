using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ты просыпаешься. Твоего котика нет. Нужно его найти!");
        Console.WriteLine("1 - Встать и искать");
        Console.WriteLine("2 - Полежать дальше");
        string a1 = Console.ReadLine();

        if (a1 == "2")
        {
            Console.WriteLine("Ты уснул. Котик обиделся и убежал к соседям. Концовка №1 ");
            return;
        }

        Console.WriteLine("Ты идёшь по дому. В какой комнате нужно начать поиск?");
        Console.WriteLine("1 - На кухне");
        Console.WriteLine("2 - В ванной");
        string a2 = Console.ReadLine();

        if (a2 == "1")
        {
            Console.WriteLine("На кухне следы лапок.");
            Console.WriteLine("1 - Проверить под столом");
            Console.WriteLine("2 - Проверить холодильник");
            string a3 = Console.ReadLine();

            if (a3 == "1")
            {
                Console.WriteLine("Под столом ничего.");
                Console.WriteLine("1 - Позвать котика");
                Console.WriteLine("2 - Идти в комнату");
                string a4 = Console.ReadLine();

                if (a4 == "1")
                {
                    Console.WriteLine("Котик не ответил. Проверить улицу?");
                    Console.WriteLine("1 - Да");
                    Console.WriteLine("2 - Нет");
                    string a5 = Console.ReadLine();

                    if (a5 == "1")
                    {
                        Console.WriteLine("Во дворе дети говорят, что видели котика у лавки.");
                        Console.WriteLine("1 - Пойти туда");
                        Console.WriteLine("2 - Пойти к мусорке");
                        string a6 = Console.ReadLine();

                        if (a6 == "1")
                        {
                            Console.WriteLine("Котик сидит на лавочке и жмурится на солнце. Концовка №2 ");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Котик играет с фантиками и ждет тебя. Концовка №3");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ты сел и устал. Котик сам тебя нашел и лёг на колени. Конковка №4 ");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("В комнате под кроватью что-то шуршит...");
                    Console.WriteLine("1 - Посмотреть");
                    Console.WriteLine("2 - Убежать");
                    string a7 = Console.ReadLine();

                    if (a7 == "1")
                    {
                        Console.WriteLine("Это котик! Он нашёл твой носок. Концовка №5");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Ты убежал. Котик обиделся и очень долго грустил. Концовка №6");
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine("В холодильнике есть только курица.");
                Console.WriteLine("1 - Съесть курицу");
                Console.WriteLine("2 - Оставить котику");
                string a8 = Console.ReadLine();

                if (a8 == "1")
                {
                    Console.WriteLine("Ты съел курицу. Котик прибежал и заплакал. Конец №7");
                    return;
                }
                else
                {
                    Console.WriteLine("Котик прибежал на запах! Концовка №8 ");
                    return;
                }
            }
        }
        else
        {
            Console.WriteLine("В ванной вода на полу.");
            Console.WriteLine("1 - Проверить за шторкой");
            Console.WriteLine("2 - Проверить стиральную машину");
            string a9 = Console.ReadLine();

            if (a9 == "1")
            {
                Console.WriteLine("За шторкой никого.");
                Console.WriteLine("1 - Проверить под раковиной");
                Console.WriteLine("2 - Выйти на балкон");
                string a10 = Console.ReadLine();

                if (a10 == "1")
                {
                    Console.WriteLine("Под раковиной кошачья игрушка!");
                    Console.WriteLine("Ты идешь по следам из ниточек в комнату — котик там, спит на диване под подушкой. Концовка №9");
                    return;
                }
                else
                {
                    Console.WriteLine("На балконе котик играет с солнечным зайчиком. Концовка №10");
                    return;
                }
            }
            else
            {
                Console.WriteLine("В стиралке носок. Котика нет.");
                Console.WriteLine("Ты слышишь мяуканье в коридоре — он там! Концовка №4 ");
                return;
            }
        }

        Console.WriteLine("Конец игры");
    }
}