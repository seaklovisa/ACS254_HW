using Common;
using StrategyPatternHW_Discount;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyPatternHW
{
    public class MovieTicket
    {
        private IBenefit benefit;

        //存所有要算的折數
        private List<string> discountList;

        //存票種來源
        private List<ComboBoxItem> tickeTypeSource;

        private int PeopleNumber { get; set; }

        public MovieTicket()
        {
            discountList = new List<string>();
            tickeTypeSource = new List<ComboBoxItem>();
            benefit = new DefaultBenefit();
        }

        /// <summary>
        /// 票種來源
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ComboBoxItem> TicketTypeDataSource()
        {
            tickeTypeSource.Clear();
            tickeTypeSource.AddRange(new ComboBoxItem[]{
                new ComboBoxItem(){ Text="學生票",Value=400},
                new ComboBoxItem(){Text="成人票",Value=500},
                new ComboBoxItem(){Text="兒童票",Value=300},
                new ComboBoxItem(){Text="屁孩票",Value=350},
                new ComboBoxItem(){Text="敬老票",Value=250}
            });

            return tickeTypeSource;
        }

        /// <summary>
        /// 屁孩折扣可選內容
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> ChildrenDiscountSource()
        {
            //dataSource.Clear();
            List<string> comboChildrenSource = new List<string>();
            comboChildrenSource.Add("");
            //讀取AppConfig ChildrenDiscount 區段的內容
            ChildrenDiscountConfig items = (ConfigurationManager.GetSection("ChildrenDiscount") as ChildrenDiscountConfig);

            foreach (DiscountElement item in items.DiscountItems)
            {
                comboChildrenSource.Add(item.Name);
            }

            return comboChildrenSource;
        }

        /// <summary>
        /// 學生折扣的可選內容
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> StudentDiscountSource()
        {
            List<string> comboStudentSource = new List<string>();
            comboStudentSource.Add("");
            //讀取AppConfig StudentDiscount 區段的內容
            StudentDiscountConfig items = (ConfigurationManager.GetSection("StudentDiscount") as StudentDiscountConfig);

            foreach (DiscountElement item in items.DiscountItems)
            {
                comboStudentSource.Add(item.Name);
            }

            return comboStudentSource;
        }

        /// <summary>
        /// 執行計算折扣 然後傳回顯示此次購買明細
        /// </summary>
        /// <param name="e"></param>
        public string OnAddListExchanged(EventArgs e)
        {
            if (e != null)
            {
                //銷售資訊
                SellInformationEventArgs sellInfo = e as SellInformationEventArgs;
                //要丟去計算的錢
                MoneyEventArgs moneyEventArgs = new MoneyEventArgs() { TicketPrice = sellInfo.TicketPrice };

                //看有幾種折價方法 ex 學生八折 勾選花旗卡 又五折 分別計算
                foreach (string discount in sellInfo.TicketOff)
                {
                    if (!string.IsNullOrWhiteSpace(discount))
                    {
                        Type type = Assembly.Load("StrategyPatternHW_Discount").GetType(discount);
                        //依折數計算後結果 更新錢參數
                        moneyEventArgs = (Activator.CreateInstance(type) as IDiscount).Calculate(moneyEventArgs);
                    }
                }

                //更新銷售資訊的折扣後價格
                sellInfo.TicketOffPrice = moneyEventArgs.TicketPrice;

                //把總價丟去計算紅利
                moneyEventArgs = new MoneyEventArgs() { TicketPrice = sellInfo.TicketOffPrice * sellInfo.TicketNumber };
                if (sellInfo.IsVIP)
                {
                    sellInfo.BenefitCount = benefit.BenefitCount(moneyEventArgs);
                }

                //銷售資訊組成顯示字串
                return UpdateSellDetail(sellInfo);
            }

            return "";
        }

        /// <summary>
        /// 更新顯示面板
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public string UpdateSellDetail(EventArgs e)
        {
            SellInformationEventArgs args = e as SellInformationEventArgs;
            return String.Format("一張{0} 原價{1} 特價{2} 共{3}張 小計：{4} {5}" + System.Environment.NewLine,
                args.TicketName, args.TicketPrice.ToString(), args.TicketOffPrice.ToString(), args.TicketNumber.ToString(), args.TicketOffPrice * args.TicketNumber
                , args.BenefitCount > 0 ? "本次紅利積點 " + args.BenefitCount.ToString() : "");
        }
    }
}