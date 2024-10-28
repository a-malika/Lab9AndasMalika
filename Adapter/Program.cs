using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory9
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Предоставление выбора
            Console.WriteLine("Введите сумму для операции: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("В какой валюте предоставлена сумма(0 - тенге, 1 - доллары, 2 - евро):");
            int ans = Convert.ToInt32(Console.ReadLine());
            IPaymentProcessor payment;
            switch (ans)
            {
                case 1:
                    payment = new PaymentAdapterA(new ExternalPaymentSystemA());
                    break;
                case 2:
                    payment = new PaymentAdapterB(new ExternalPaymentSystemB());
                    break;
                default:
                    payment = new InternalPaymentProcessor();
                    break;
            }
            Console.WriteLine("Какую операцию желаете провести(0 - платеж, 1 - возврат):");
            ans = Convert.ToInt32(Console.ReadLine());
            switch (ans)
            {
                case 0:
                    payment.ProcessPayment(amount);
                    break;
                case 1:
                    payment.RefundPayment(amount);
                    break;
                default:
                    Console.WriteLine("Неподдерживаемая операция.");
                    break;
            }

            // Проверка каждой платежной системы

            Console.WriteLine();

            ExternalPaymentSystemA externalA = new ExternalPaymentSystemA();
            IPaymentProcessor paymentA = new PaymentAdapterA(externalA);
            paymentA.ProcessPayment(1000);
            paymentA.RefundPayment(100);

            Console.WriteLine();

            ExternalPaymentSystemB externalB = new ExternalPaymentSystemB();
            IPaymentProcessor paymentB = new PaymentAdapterB(externalB);
            paymentB.ProcessPayment(2000);
            paymentB.RefundPayment(200);

            Console.WriteLine();

            IPaymentProcessor internal1 = new InternalPaymentProcessor();
            internal1.ProcessPayment(3000);
            internal1.RefundPayment(300);
        }
    }
}
