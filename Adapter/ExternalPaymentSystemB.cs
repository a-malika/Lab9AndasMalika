using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory9
{
    public class ExternalPaymentSystemB
    {
        public void SendPayment(double amount)
        {
            Console.WriteLine($"Payment {amount} by external payment system B");
        }
        public void ProcessRefund(double amount)
        {
            Console.WriteLine($"Refund {amount} by external payment system B");
        }
    }
}
