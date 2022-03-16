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
        //public void AddItem(decimal price, decimal quantity)
        //{
        //    LineItem l = new LineItem();
        //    l.CreateList(price, quantity);      //consider making 2 lists

        //    ConsoleIO.DisplayMessage($"");      //check list 
        //}

        //FinalizeOrder(Order)
    }
}
