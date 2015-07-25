using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternHW_Discount
{
    public class DefaultBenefit : IBenefit
    {
        //100元換一點
        public int BenefitCount(MoneyEventArgs price)
        {
            return price.TicketPrice / 100;
        }
    }
}