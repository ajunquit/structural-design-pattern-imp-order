using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structural_design_pattern_imp_order
{
    public class GreetingCardDecorator : OrderDecorator
    {
        public GreetingCardDecorator(IOrder order) : base(order)
        {
        }

        public override decimal GetTotalPrice()
        {
            return (decimal)2.50;
        }

        public override string GetDescription()
        {
            return _order.GetDescription() + " >> Adding Greeting Card...";
        }
    }
}
