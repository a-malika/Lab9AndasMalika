using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory9
{
    public class ChocolateDecorator : BeverageDecorator
    {
        public ChocolateDecorator(IBeverage beverage) : base(beverage) { }
        public override double GetCost()
        {
            return base.GetCost() + 50.0;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " Chocolate";
        }
    }
}
