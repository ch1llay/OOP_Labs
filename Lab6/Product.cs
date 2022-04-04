using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Product
    {
        Random random = new Random();
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Product(int number)
        {
            Name = $"Товар {number}";
            Price = (decimal)random.Next(10, 2000);
        }
        public override string ToString()
        {
            return $"{Name}\nЦена {Price}";
        }
    }
}
