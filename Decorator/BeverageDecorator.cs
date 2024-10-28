using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory9
{
    public abstract class BeverageDecorator : IBeverage
    {
        private IBeverage _beverage;
        public BeverageDecorator(IBeverage beverage)
        {
            _beverage = beverage;
        }
        public virtual double GetCost()
        {
            return _beverage.GetCost();
        }
        public virtual string GetDescription()
        {
            return _beverage.GetDescription();
        }
    }
}
