using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class HardwareInternetShop : OnlineStore
    {
        public HardwareInternetShop(string title, string adress) : base(title, adress) { }
        public override string PlaceAnOrder()
        {
            return "Заказ в строительном магазине оформлен";
        }
    }
}
