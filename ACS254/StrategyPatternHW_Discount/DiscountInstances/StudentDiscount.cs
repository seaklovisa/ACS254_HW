using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternHW_Discount
{
    /// <summary>
    /// 學生憑學生證可享受票價8折優惠
    /// </summary>
    public class StudentDiscount : IDiscount
    {
        public MoneyEventArgs Calculate(MoneyEventArgs price)
        {
            price.TicketPrice = Convert.ToInt32(Math.Floor(price.TicketPrice * 0.8));
            return price;
        }
    }
}