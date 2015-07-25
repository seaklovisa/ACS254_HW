using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternHW_Discount
{
    public class MoneyEventArgs : EventArgs
    {
        //票價
        public int TicketPrice { get; set; }
    }
}