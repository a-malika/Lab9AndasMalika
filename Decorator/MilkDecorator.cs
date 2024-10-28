using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory9
{
    public class MilkDecorator : BeverageDecorator
    {
        public MilkDecorator(IBeverage beverage) : base(beverage) { }
        public override double GetCost()
        {
            return base.GetCost() + 20.0;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " Milk";
        }
    }
}
