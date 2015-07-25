using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternHW_Discount
{
    /// <summary>
    /// 打折用
    /// </summary>
    public interface IDiscount
    {
        //計算打折
        MoneyEventArgs Calculate(MoneyEventArgs price);
    }
}