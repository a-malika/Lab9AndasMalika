using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory9
{
    public class VanillaDecorator : BeverageDecorator
    {
        public VanillaDecorator(IBeverage beverage) : base(beverage) { }
        public override double GetCost()
        {
            return base.GetCost() + 30.0;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " Vanilla";
        }
    }
}
