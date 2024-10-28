using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory9
{
    public class InternalPaymentProcessor : IPaymentProcessor
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Payment {amount} by internal payment system");
        }
        public void RefundPayment(double amount)
        {
            Console.WriteLine($"Refund {amount} by internal payment system");
        }
    }
}
