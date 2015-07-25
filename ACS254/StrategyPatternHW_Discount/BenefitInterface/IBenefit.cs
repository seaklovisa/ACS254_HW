using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternHW_Discount
{
    /// <summary>
    /// 集點用
    /// </summary>
    public interface IBenefit
    {
        //計算紅利積點
        int BenefitCount(MoneyEventArgs price);
    }
}