using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCheckOut
{
    class Validation
    {
        private static string PromptUser(string message)
        {
            Console.Write(message);
            return Console.ReadLine() ?? string.Empty;
        }
        internal static decimal PromptUser4Dec(string message)
        {
            decimal result;
            while (!(decimal.TryParse(PromptUser(message), out result)))
            {
                PromptUser($@"Invalid Input, +
                Press Enter to Continue");
            }

            return result;
        }
    }
}
