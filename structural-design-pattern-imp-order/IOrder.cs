using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structural_design_pattern_imp_order
{
    public interface IOrder
    {
        decimal GetTotalPrice();
        string GetDescription();
    }
}
