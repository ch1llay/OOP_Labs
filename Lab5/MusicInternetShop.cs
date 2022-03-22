using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class MusicInternetShop : OnlineStore
    {
        public MusicInternetShop(string title, string adress) : base(title, adress) { }
        public override string PlaceAnOrder()
        {
            return "Заказ в музыкальном магазине оформлен";
        }
    }
}
