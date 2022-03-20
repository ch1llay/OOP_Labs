using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class MusicInternetShop : OnlineStore
    {
        public override string PlaceAnOrder()
        {
            return "Заказ в музыкльном магазине оформлен";
        }
    }
}
