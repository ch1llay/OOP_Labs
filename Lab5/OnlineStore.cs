using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Product
    {
        Random random = new Random();
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Product(int count)
        {
            Name = $"Товар {count}";
            Price = (decimal)random.Next(10, 2000);
        }
    }
    public class OnlineStore
    {
        
        string adress;
        public string Adress { get { return adress; } private set { adress = value; } }
        public List<Product> Products { get; set; } = new List<Product>();

        public string Title { get; private set; }
        public int AmountSoldProducts { get; private set; }
        public int AmountKindProducts { get; private set; }
        public decimal CurrentProfit { get; private set; }
        public int AmountOlineUsers { get; private set; }

        public int ProductCount { get; private set; }
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

        public virtual string PlaceAnOrder()
        {
            return "заказ в интеренет магазине оформлен";
        }
        public static OnlineStore operator +(OnlineStore onlineStore, Product product)
        {
            // при добалении считается какой-то по счету объект был добавлен для конкретного интернет магазина
            onlineStore.Products.Add(product);
            onlineStore.ProductCount++;
            return onlineStore;
        }


    }
}
