using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structural_design_pattern_imp_order
{
    public abstract class OrderDecorator : IOrder
    {
        protected readonly IOrder _order;

        public OrderDecorator(IOrder order)
        {
            this._order = order;
        }
        public virtual string GetDescription()
        {
            return this._order.GetDescription();
        }

        public virtual decimal GetTotalPrice()
        {
            return this._order.GetTotalPrice();
        }
    }
}
