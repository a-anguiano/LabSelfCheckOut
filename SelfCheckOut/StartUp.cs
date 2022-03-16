using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCheckOut
{
    class StartUp
    {
        private readonly OrderService _orderService = new OrderService();
        public void Run()
        {
            decimal tax = ConsoleIO.GetTax();

            while (true)
            {
                if (GetItemEntries()) break;
            }
            
        }

        public bool GetItemEntries()
        {
            decimal price = ConsoleIO.GetPrice();


            if (price == 0)        
            {
                ConsoleIO.DisplayMessage("===========");
                ConsoleIO.DisplayMessage("RECEIPT");
                ConsoleIO.DisplayMessage("===========");
//                3 items @ $2.00   $6.00
//Sales Tax: .07    $0.42
//Total:           $6.42
//===============
//Press Any Key To Continue
                //press any key to continue, Console.ReadKey()
                //Console.Clear()
                return true;
            }
            else if (price.ToString().ToUpper() == "Q")      
            {
                ConsoleIO.DisplayMessage("Goodbye.");
                Environment.Exit(0);
                return false;
            }
            else
            {
                decimal quantity = ConsoleIO.GetQuantity();
                ConsoleIO.DisplayMessage($"{quantity} items @ {price:c}");
                //messages 3 items @ $2.00
                return true;
            } 
        }
    }
}
