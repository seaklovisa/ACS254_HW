using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternHW_Discount.DiscountInstances
{
    /// <summary>
    /// 小學生與屁孩7折
    /// </summary>
    public class ElementaryDiscount : IDiscount
    {
        public MoneyEventArgs Calculate(MoneyEventArgs price)
        {
            price.TicketPrice = Convert.ToInt32(Math.Floor(price.TicketPrice * 0.7));
            return price;
        }
    }
}