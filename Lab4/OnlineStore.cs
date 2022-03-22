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
        public string Adress { get { return adress; } private set { adress = value; } }

        public string Title { get; private set; }
        public int AmountSoldProducts { get; private set; }
        public int AmountKindProducts { get; private set; }
        public decimal CurrentProfit { get; private set; }
        public int AmountOlineUsers { get; private set; }
        public int AmountRegUsers { get; private set; }


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
        public string ShowAmoountOnline()
        {
            return $"Текущий онлайн пользователей {AmountOlineUsers}";
        }
        abstract public string PlaceAnOrder();

    }
}
