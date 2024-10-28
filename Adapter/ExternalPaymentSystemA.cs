using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory9
{
    public class ExternalPaymentSystemA
    {
        public void MakePayment(double amount)
        {
            Console.WriteLine($"Payment {amount} by external payment system A");
        }
        public void MakeRefund(double amount)
        {
            Console.WriteLine($"Refund {amount} by external payment system A");
        }
    }
}
