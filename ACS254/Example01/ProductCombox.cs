using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public class ProductCombox : ComboBox
    {
        private bool isGroupHeader = false;
        private string header = "";

        public ProductCombox()
            : base()
        {
            this.DrawMode = DrawMode.OwnerDrawVariable;
            this.DropDownHeight = 200;
        }

        /// <summary>
        /// 判斷要不要畫群組標題及相關設定
        /// </summary>
        /// <param name="index"></param>
        /// <param name="header"></param>
        /// <returns></returns>
        private bool IsGroupHeader(int index, out string header)
        {
            bool isGroupHeader = false;
            if (index - 1 < 0)
            {
                //第一個是群組標題
                header = (Items[index] as Product).CategoryName;
                isGroupHeader = true;
            }
            else
            {
                header = (Items[index] as Product).CategoryName;
                //跟上一個比一樣就不是群組標題
                isGroupHeader = header == (Items[index - 1] as Product).CategoryName ? false : true;
            }

            return isGroupHeader;
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);
            e.DrawBackground();
            if (e.Index < 0)
            {
                return;
            }

            if (this.Items[e.Index] is Product)
            {
                //如果是產品
                Product product = this.Items[e.Index] as Product;

                //建立字型
                Font font = new Font(FontFamily.GenericMonospace, 12, FontStyle.Bold);
                //來支筆刷 紅色熱賣優先 然後是藍色 然後是本色
                Brush brush = new SolidBrush(product.Hot.IsEmpty ?
                    (product.OffPrice > 0 ? product.OffColor : product.ForeColor) : product.Hot);

                Brush headerBrush = new SolidBrush(Color.Black);

                //判斷是不是群組標題
                isGroupHeader = IsGroupHeader(e.Index, out header);

                //建一個標頭用的方塊 高度為一半
                Rectangle groupRectangle = new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height / 2);

                //建立一個縮排的方塊
                Rectangle itemRectangle = new Rectangle(
                e.Bounds.X + 12, //右移 12
                    //如果是群組第一個 就把位置下移 變成在群組標題下面的感覺 不做坐標移動會都在同一行
                    e.Bounds.Y + (isGroupHeader ? (e.Bounds.Height / 2) : 0),
                e.Bounds.Width, e.Bounds.Height
                );
                //群組標題就把顏色設成背景設 就不會被選到
                if (isGroupHeader)
                    e.Graphics.FillRectangle(new SolidBrush(BackColor), groupRectangle);
                //畫標題
                if (isGroupHeader)
                    e.Graphics.DrawString(header, font, headerBrush, groupRectangle);
                //畫item
                e.Graphics.DrawString(product.ToString(), Font, brush, itemRectangle);
            }
        }

        protected override void OnMeasureItem(MeasureItemEventArgs e)
        {
            base.OnMeasureItem(e);
            //製造一點空隙
            e.ItemHeight = Font.Height + 5;
            //畫標題的時候 是畫 標題 + item 所以*2
            if (IsGroupHeader(e.Index, out header))
                e.ItemHeight = e.ItemHeight * 2;
        }
    }
}