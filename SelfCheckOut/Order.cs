using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCheckOut
{
    class Order
    {
        //List
        public List<decimal> CreateList()
        {
            List<decimal> lineItems = new List<decimal>();
            return lineItems;
        }

        public decimal CalcTotalItemCost(List<decimal> lineItems)
        {
            decimal totItem = 0;
            for (int i = 0; i<lineItems.Count; i+=2)
            {
                totItem = lineItems.ElementAt(i) * lineItems.ElementAt(i + 1);
                ConsoleIO.DisplayMessage($"{totItem}");
                
            }

            return totItem;
            //listItems(1) * listItems.ElementAt(0);     //2 lists, or grab 
            //each total item cost without tax

            //send total w/out tax to the CalcSalesTax


            //var firstItem = myList.ElementAt(0);
            //Console.WriteLine(firstItem);
        }

        //SalesTax
        public void CalcSalesTax()
        {
            decimal tax = ConsoleIO.GetTax();

            // tax * CalcTotalItemCost      
            // divide by 100
        }

        //OrderTotal
        //tax + total


        //Implement a ToString() override to format a string for output ?

        //method, callback to lineitem for price and quantity
    }
}
