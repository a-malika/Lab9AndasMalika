using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory9
{
    public class Coffee : IBeverage
    {
        public double GetCost()
        {
            return 200;
        }
        public string GetDescription()
        {
            return "Coffee";
        }
    }
}
