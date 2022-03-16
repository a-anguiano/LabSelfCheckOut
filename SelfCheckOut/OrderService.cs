using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCheckOut
{
    class OrderService
    {
        public int Tax { get; private set; }    //perhaps

        //AddItem(Order, LineItem)
        //rename to AddItem

        public void AddItem(Order o, LineItem l)
        {
            List<decimal> lineItems = o.CreateList();
            decimal price = l.GetPriceForService();
            decimal quantity = l.GetQuantForService();
            lineItems.Add(price);
            lineItems.Add(quantity);
        }

        

        //FinalizeOrder(Order)
        //receipt
    }
}
