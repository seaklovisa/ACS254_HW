using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternHW_Discount
{
    /// <summary>
    /// 花旗卡可以半價 可累積點數
    /// </summary>
    public class VIPDiscount : IDiscount
    {
        public MoneyEventArgs Calculate(MoneyEventArgs price)
        {
            price.TicketPrice = Convert.ToInt32(Math.Floor(price.TicketPrice * 0.5));
            return price;
        }
    }
}