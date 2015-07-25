using StrategyPatternHW.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StrategyPatternHW
{
    public partial class TicketForm : Form
    {
        private MovieTicket movieTicket;
        private List<string> ticketOffList;

        private IEnumerable<ComboBoxItem> ticketTypeItems;

        public TicketForm()
        {
            InitializeComponent();
            ticketOffList = new List<string>();
            movieTicket = new MovieTicket();
            ticketTypeItems = movieTicket.TicketTypeDataSource();
            //讀取學生折扣的內容
            this.comboStudent.DataSource = movieTicket.StudentDiscountSource();
            //讀取屁孩折扣的內容
            this.comboChildren.DataSource = movieTicket.ChildrenDiscountSource();
            //讀取票種的內容
            this.comboTicketType.DataSource = ticketTypeItems;
        }

        private void btnAddList_Click(object sender, EventArgs e)
        {
            ticketOffList.Clear();

            //檢查所選票種
            foreach (var item in ticketTypeItems)
            {
                //選擇的票種與票種來源比較
                if ((this.comboTicketType.SelectedItem as ComboBoxItem).Text == item.Text)
                {
                    //根據所選票種 回應對應的折數 以List<string> 表示 因可能選了學生八折 又勾花旗卡五折
                    //選兒童票 or 屁孩票 就要選屁孩折扣
                    //選學生票 就取學生折扣
                    ticketOffList = DiscountListSimpleFactory.DiscountListStore(
                        item.Text, this.chkIsVIP.Checked, this.comboStudent.SelectedValue.ToString(), this.comboChildren.SelectedValue.ToString());

                    //呼叫更新事件 並接收更新字串
                    this.txtDetail.Text += movieTicket.OnAddListExchanged(new SellInformationEventArgs()
                    {
                        IsVIP = this.chkIsVIP.Checked,
                        //沒填人數 給1
                        TicketNumber = string.IsNullOrWhiteSpace(txtTicketCount.Text) ? 1 : int.Parse(txtTicketCount.Text),
                        TicketOff = ticketOffList,
                        TicketName = item.Text,
                        TicketPrice = item.Value
                    });

                    break;
                }
            }
        }
    }
}