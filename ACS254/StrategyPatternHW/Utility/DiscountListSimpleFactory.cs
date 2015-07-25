using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternHW.Utility
{
    public class DiscountListSimpleFactory
    {
        /// <summary>
        /// 據選擇的票種 套用對應的折扣方法 ex學生票就套學生折扣 屁孩票or兒童票 套屁孩折扣
        ///
        /// </summary>
        /// <param name="ticketTypeName"></param>
        /// <param name="studentDiscount"></param>
        /// <param name="ChildrenDiscount"></param>
        /// <returns></returns>
        public static List<string> DiscountListStore(string ticketTypeName, bool isVip, string studentDiscount, string childrenDiscount)
        {
            List<string> result = new List<string>();

            //有勾vip 打五折
            if (isVip)
                result.Add(ConfigurationManager.AppSettings["五折"].ToString());

            if (ticketTypeName == "學生票" && !string.IsNullOrWhiteSpace(studentDiscount))
                result.Add(ConfigurationManager.AppSettings[studentDiscount].ToString());

            if ((ticketTypeName == "屁孩票" || ticketTypeName == "兒童票") && !string.IsNullOrWhiteSpace(childrenDiscount))
                result.Add(ConfigurationManager.AppSettings[childrenDiscount].ToString());

            return result;
        }
    }
}