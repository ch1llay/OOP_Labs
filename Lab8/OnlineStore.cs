using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class OnlineStore : IComparable<MyList<Product>>
    {

        public string Address { get; set; }
        public string Title { get; set; }
        public int AmountSoldProducts { get; set; }
        public int AmountKindProducts { get; set; }
        public decimal AurrentProfit { get; set; }
        public int AmountRegUsers { get; set; }
        public MyList<Product> Products;

        public OnlineStore(string adress, string title, int amountSoldProducts, int amountRegUsers)
        {
            Title = title;
            AmountSoldProducts = amountSoldProducts;
            this.AmountRegUsers = amountRegUsers;
            Products = new MyList<Product>();
        }

        private string GetProducts()
        {
            var stringBuilder = new StringBuilder();
            foreach (var product in Products)
            {
                stringBuilder.Append(product.ToString() + "\n");
            }
            return stringBuilder.ToString();
        }
        public override string ToString()
        {
            return
                $"Название интернет магазина {Title}\n" +
                $"Адрес интернет магазина {Address}\n" +
                $"Количество проданных товаров {AmountSoldProducts}\n" +
                $"Количество зарегистрированных пользователей {AmountRegUsers}" +
                $"Количество различных товаров на сайте {AmountKindProducts}\n" +
                $"Продукты\n{GetProducts()}";

        }


        public int CompareTo(MyList<Product>? other)
        {
            return Products.Count - other.Count;
        }
    }
}
