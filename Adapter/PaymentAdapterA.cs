using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory9
{
    public class PaymentAdapterA : IPaymentProcessor
    {
        private ExternalPaymentSystemA externalPaymentSystemA;
        public PaymentAdapterA(ExternalPaymentSystemA externalPaymentSystemA)
        {
            this.externalPaymentSystemA = externalPaymentSystemA;
        }
        public void ProcessPayment(double amount)
        {
            Console.WriteLine("Adapting...");
            externalPaymentSystemA.MakePayment(amount);
        }
        public void RefundPayment(double amount)
        {
            Console.WriteLine("Adapting...");
            externalPaymentSystemA.MakeRefund(amount);
        }
    }
}
