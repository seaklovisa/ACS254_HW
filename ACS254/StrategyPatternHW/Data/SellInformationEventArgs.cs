using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternHW
{
    /// <summary>
    /// 銷售資訊
    /// </summary>
    public class SellInformationEventArgs : EventArgs
    {
        //原價
        public int TicketPrice { get; set; }

        //張數
        public int TicketNumber { get; set; }

        //折扣方法
        public IEnumerable<string> TicketOff { get; set; }

        //有沒有vip卡
        public bool IsVIP { get; set; }

        //票種
        public string TicketName { get; set; }

        //折扣後票價
        public int TicketOffPrice { get; set; }

        //紅利點數
        public int BenefitCount { get; set; }
    }
}