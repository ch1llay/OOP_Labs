using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public delegate void ProductHandler(string message);
    class OnlineStore
    {
        public event ProductHandler ProductAdded;
        public string Title { get; set; }

        public OnlineStore(string title)
        {
            Title = title;
            products = new List<Product>();
        }

        private List<Product> products;
        public void AddProduct(Product product)
        {
            products.Add(product);
            ProductAdded($"Продукт {product} добален");
        }
    }
}
