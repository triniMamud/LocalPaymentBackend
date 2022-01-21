using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TarjetasApp.Helpers
{
    public class TransactionHelpers
    {
        //Una operación es válida en el sistema si la persona que opera en el mismo consume menos de 100
        public static bool IsTransactionValid(double amount)
        {
            return amount < 100;
        }
    }
}
