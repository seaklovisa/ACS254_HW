using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    public class Product
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public Color ForeColor { get; set; }

        public string CategoryName { get; set; }

        //熱賣
        public Color Hot { get; set; }

        //折扣價格
        public int OffPrice { get; set; }

        //折扣色 唯獨
        public Color OffColor { get { return Color.Blue; } }

        public override string ToString()
        {
            string s = string.Format("{0}, 今日價格:{1} {2} {3}", this.Name, this.Price
                , OffPrice > 0 ? "超級特價 " + OffPrice.ToString() : ""
                , !Hot.IsEmpty ? "熱賣" : "");
            return s;
        }
    }
}