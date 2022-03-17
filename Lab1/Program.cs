using System;
using System.Text.RegularExpressions;

namespace Lab1
{
    class Program
    {
        static void ShowMenu()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("1 - вывести содержимое объекта\n" +
                                "2 - вывести название поля\n" +
                                "3 - вывести название поля через метод\n" +
                                "4 - вывод поля в 16-ом виде\n" +
                                "5 - изменение целочисленного поля количество видов товаров на сайте\n" +
                                "6 - изменение вещественного поля текущая прибыль\n" +
                                "7 - изменение строкового поля название интернет магазина\n" +
                                "0 - выход из программы"
                                );
            Console.WriteLine("--------------------------------------");
        }
        static void Main(string[] args)
        {
            OnlineStore onlineStore = new OnlineStore("BuyPhones.ru", "Наушники на любой вкус", 131, 100, 123401.012m, 22, 15);

            Console.WriteLine("Приветствую. Лабораторная работа № 1. Класс. Создание объекта. Работа с консолью.\n" +
                "Варинт 11 Интернет магазин. Чапаев Илья");
            bool run = true;
            int userInput = 0;
            while (run)
            {
                ShowMenu();
                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("возникла ошибка в выборе пункта");
                    continue;
                }
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("Вывод объекта через перегрузку методо ToString()");
                        Console.WriteLine(onlineStore);
                        break;
                    case 2:
                        Console.WriteLine($"Вывод поля -> Название интренет магазина {onlineStore.title}");
                        break;
                    case 3:
                        Console.WriteLine("Метод который реализует вывод одного поля");
                        onlineStore.ShowAmoountOnline();
                        break;
                    case 4:
                        Console.WriteLine("Вывод параметра в 16 ричном виде");
                        Console.WriteLine(onlineStore.amountRegUsers.ToString("X2"));
                        break;
                    case 5:
                        Console.WriteLine("Введите новое количество видов товаров ");
                        try
                        {
                            onlineStore.amountKindProducts = Convert.ToInt32(Console.ReadLine());
                            if(onlineStore.amountKindProducts < 0)
                            {
                                throw new Exception();
                            }
                            Console.WriteLine("изменения успешно сохранены");
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine("Возникла ошибка");
                        }
                        break;
                    case 6:
                        Console.WriteLine("Введите новое Значение текущей прибыли ");
                        try
                        {
                            onlineStore.currentProfit = Convert.ToDecimal(Console.ReadLine());
                            
                            Console.WriteLine("изменения успешно сохранены");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Возникла ошибка");
                        }
                        break;
                    case 7:
                        Console.WriteLine("Введите новое название интернет магазина");
                        try
                        {
                            var s = Console.ReadLine();
                            string pattern = @"[а-яА-Я]+";
                            if (!Regex.IsMatch(s, pattern))
                            {
                                throw new Exception();
                            }
                            onlineStore.title = s;
                            
                            Console.WriteLine("изменения успешно сохранены");
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Возникла ошибка");
                        }
                        break;
                    case 0:
                        run = false;
                        break;
                    default:
                        Console.WriteLine("ошибка в выборе пункта меню");
                        break;
                }
            }
            


        }
    }
}
