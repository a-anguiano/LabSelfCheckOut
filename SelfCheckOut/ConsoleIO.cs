using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCheckOut
{
    class ConsoleIO
    {
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        public static decimal GetTax()
        {
            return Validation.PromptUser4Dec("Enter the tax: % "); //decimal?, for now assuming whol number, ex. 7%
        }

        public static decimal GetPrice()
        {
            return Validation.PromptUser4Dec("Enter the price: ");
        }

        public static decimal GetQuantity()
        {
            return Validation.PromptUser4Dec("Enter the quantity: ");
        }
    }
}
