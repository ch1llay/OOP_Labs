using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class OnlineStore
    {
        public string address;
        public string title;
        public int amountSoldProducts;
        public int amountKindProducts;
        public decimal currentProfit;
        public int amountOlineUsers;
        public int amountRegUsers;

        public OnlineStore() { }
        public OnlineStore(string title)
        {
            this.title = title;
        }

        public OnlineStore(string address, string title, int amountSoldProducts, int amountProducts, decimal currentProfit, int amountOlineUsers, int amountRegUsers) : this(address)
        {
            this.title = title;
            this.amountSoldProducts = amountSoldProducts;
            this.amountKindProducts = amountProducts;
            this.currentProfit = currentProfit;
            this.amountOlineUsers = amountOlineUsers;
            this.amountRegUsers = amountRegUsers;
        }

        public override string ToString()
        {
            return $"Название интернет магазина {title}\n" +
                $"Адрес интернет магазина {address}\n" +
                $"Количество проданных товаров {amountSoldProducts}\n" +
                $"Количество различных товаров на сайте {amountKindProducts}\n" +
                $"Текущая прибыль {currentProfit}\n" +
                $"Текущий онлайн пользователей {amountOlineUsers}\n" +
                $"Количество зарегистрированных пользователей {amountOlineUsers}";
        }
        public void ShowAmoountOnline()
        {
            Console.WriteLine($"Текущий онлайн пользователей {amountOlineUsers}");
        }

    }
}
