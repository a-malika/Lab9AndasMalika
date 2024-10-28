using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory9
{
    public class CinnamonDecorator : BeverageDecorator
    {
        public CinnamonDecorator(IBeverage beverage) : base(beverage) { }
        public override double GetCost()
        {
            return base.GetCost() + 15.0;
        }
        public override string GetDescription()
        {
            return base.GetDescription() + " Cinnamon";
        }
    }
}
