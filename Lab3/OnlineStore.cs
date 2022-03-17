using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class OnlineStore
    {
        public static int objectCount;
        public string adress
        {
            get { return adress; }
            set
            {
                if (string.IsNullOrEmpty(value)){
                    adress = string.Empty;
                }
                adress = value;
            }
        }

        public string title;
        public int amountSoldProducts;
        public int amountKindProducts;
        public decimal currentProfit;
        public int amountOlineUsers;
        public int amountRegUsers;


        /// <summary>
        /// 
        /// </summary>
        public OnlineStore()
        {
            objectCount++;
        }
        public OnlineStore(string title)
        {
            objectCount++;
            this.title = title;
        }

        public OnlineStore(string adress, string title)
        {
            objectCount++;
            this.adress = adress;
            this.title = title;
        }

        public OnlineStore(string adress, string title, int amountSoldProducts, int amountProducts, decimal currentProfit, int amountOlineUsers, int amountRegUsers)
        {
            objectCount++;
            this.adress = adress;
            this.title = title;
            this.amountSoldProducts = amountSoldProducts;
            this.amountKindProducts = amountProducts;
            this.currentProfit = currentProfit;
            this.amountOlineUsers = amountOlineUsers;
            this.amountRegUsers = amountRegUsers;
        }


        public string ToString()
        {
            return
                $"Название интернет магазина {title}\n" +
                $"Адрес интернет магазина {adress}\n" +
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
