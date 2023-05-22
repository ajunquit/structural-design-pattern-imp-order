using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structural_design_pattern_imp_order
{
    public class Order : IOrder
    {
        public string GetDescription()
        {
            return "Getting the 'Description' field from base component 'Order' class...";
        }

        public decimal GetTotalPrice()
        {
            return (decimal)0.50;
        }
    }
}
