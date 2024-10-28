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

            IBeverage beverage1 = new Coffee();
            beverage1 = new MilkDecorator(beverage1);
            beverage1 = new ChocolateDecorator(beverage1);
            beverage1 = new CinnamonDecorator(beverage1);
            beverage1 = new VanillaDecorator(beverage1);
            Console.WriteLine(beverage1.GetDescription());
            Console.WriteLine(beverage1.GetCost());

            IBeverage beverage2 = new Tea();
            beverage2 = new MilkDecorator(beverage2);
            beverage2 = new SugarDecorator(beverage2);
            Console.WriteLine(beverage2.GetDescription());
            Console.WriteLine(beverage2.GetCost());
        }
    }
}
