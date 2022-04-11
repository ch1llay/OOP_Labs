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
        public event ProductHandler ProductsWork;
        public string Title { get; set; }

        public OnlineStore(string title)
        {
            Title = title;
            products = new Dictionary<string, Product>();
        }

        private Dictionary<string, Product> products;
        public void AddProduct(Product product)
        {
            if (!products.ContainsKey(product.Name))
            {
                products.Add(product.Name, product);
                ProductsWork($"Продукт {product} добален");
            }
            else
            {
                ProductsWork($"Продукт {product} уже есть!");
            }
        }
        public void DeleteProduct(Product product)
        {
            if (products.ContainsKey(product.Name))
            {
                products.Remove(product.Name);
                ProductsWork($"Продукт {product} удален");
            }
            else
            {
                ProductsWork($"Продукта {product} продукта нет!");
            }
        }

    }
}
