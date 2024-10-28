using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory9
{
    public class PaymentAdapterB : IPaymentProcessor
    {
        private ExternalPaymentSystemB externalPaymentSystemB;
        public PaymentAdapterB(ExternalPaymentSystemB externalPaymentSystemB)
        {
            this.externalPaymentSystemB = externalPaymentSystemB;
        }
        public void ProcessPayment(double amount)
        {
            Console.WriteLine("Adapting...");
            externalPaymentSystemB.SendPayment(amount);
        }
        public void RefundPayment(double amount)
        {
            Console.WriteLine("Adapting...");
            externalPaymentSystemB.ProcessRefund(amount);
        }
    }
}
