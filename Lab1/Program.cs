using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            OnlineStore onlineStore = new OnlineStore("BuyPhones.ru", "Наушники на любой вкус", 131, 100, 123401.012m, 22, 15);

            Console.WriteLine("Приветствую. Лабораторная работа № 1. Класс. Создание объекта. Работа с консолью.\n" +
                "Варинт 11 Интернет магазин. Чапаев Илья");
            Console.WriteLine($"Вывод поля - Название интренет магазина {onlineStore.title}");
            Console.WriteLine("Метод который реализует вывод одного поля");
            onlineStore.ShowAmoountOnline();
            Console.WriteLine("Вывод объекта через перегрузку ToString()");
            Console.WriteLine(onlineStore);
            Console.WriteLine("Вывод параметра в 16 ричном виде");
            Console.WriteLine(onlineStore.amountRegUsers.ToString("X2"));
        }
    }
}
