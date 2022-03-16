using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCheckOut
{
    class LineItem
    {
        //public void GetLineItem()
        //{
        // decimal price = ConsoleIO.GetPrice();       //readonly, protection, private
        // decimal quantity = ConsoleIO.GetQuantity();
        //}    

        public decimal GetPriceForService()
        {
            decimal price = ConsoleIO.GetPrice();
            return price;
        }

        public decimal GetQuantForService()
        {
            decimal quantity = ConsoleIO.GetQuantity();
            return quantity;
        }
    }
}
