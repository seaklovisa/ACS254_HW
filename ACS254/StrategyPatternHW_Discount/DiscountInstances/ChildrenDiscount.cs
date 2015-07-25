using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternHW_Discount
{
    /// <summary>
    /// 10周歲以下兒童三折
    /// </summary>
    public class ChildrenDiscount : IDiscount
    {
        public MoneyEventArgs Calculate(MoneyEventArgs price)
        {
            price.TicketPrice = Convert.ToInt32(Math.Floor(price.TicketPrice * 0.3));
            return price;
        }
    }
}