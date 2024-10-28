using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory9
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(double amount);
        void RefundPayment(double amount);
    }
}
