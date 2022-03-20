using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    abstract class OnlineStore
    {
        string adress;
        public string Adress
        {
            get { return adress; }
            private set { }
        }

        public string Title;
        public int AmountSoldProducts;
        public int AmountKindProducts;
        public decimal CurrentProfit;
        public int AmountOlineUsers;
        public int AmountRegUsers;


        public OnlineStore()
        {
        }
        public OnlineStore(string title)
        {
            this.Title = title;
        }

        public OnlineStore(string adress, string title)
        {
            this.adress = adress;
            this.Title = title;
        }

        public OnlineStore(string adress, string title, int amountSoldProducts, int amountProducts, decimal currentProfit, int amountOlineUsers, int amountRegUsers)
        {
            this.adress = adress;
            this.Title = title;
            this.AmountSoldProducts = amountSoldProducts;
            this.AmountKindProducts = amountProducts;
            this.CurrentProfit = currentProfit;
            this.AmountOlineUsers = amountOlineUsers;
            this.AmountRegUsers = amountRegUsers;
        }


        public override string ToString()
        {
            return
                $"Название интернет магазина {Title}\n" +
                $"Адрес интернет магазина {adress}\n" +
                $"Количество проданных товаров {AmountSoldProducts}\n" +
                $"Количество различных товаров на сайте {AmountKindProducts}\n" +
                $"Текущая прибыль {CurrentProfit}\n" +
                $"Текущий онлайн пользователей {AmountOlineUsers}\n" +
                $"Количество зарегистрированных пользователей {AmountOlineUsers}";
        }
        public void ShowAmoountOnline()
        {
            Console.WriteLine($"Текущий онлайн пользователей {AmountOlineUsers}");
        }
        abstract public string PlaceAnOrder();

    }
}
